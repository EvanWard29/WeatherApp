using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152_Coursework2018
{
    public partial class frmAverageMinTemp : Form
    {
        public static frmAverageMinTemp frmAvgMin = null;
        public frmAverageMinTemp()
        {
            InitializeComponent();
            frmAvgMin = this;
        }

        private void frmAverageMinTemp_Load(object sender, EventArgs e)
        {
            loadLocations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmYearlyObsv tempYear = new frmYearlyObsv();
            tempYear.Show();
            frmAvgMin.Close();
        }

        private void drpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.drpLocation.SelectedIndex != 0)
            {
                avgValues = null;
                Years = null;

                loadDetails();

                if (avgValues != null)
                {
                    drawYAxis();
                    drawXAxis();

                    drawGraph();
                }
                else
                {  
                    this.pnlGraph.Refresh();

                    DialogResult result = MessageBox.Show("No Data Could be Found for the Location " +
                        this.drpLocation.SelectedItem.ToString() + ".\nWould you Like to Add Data?", "Error",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        frmAddData tempFrmData = new frmAddData();
                        tempFrmData.Show();
                        frmAvgMin.Close();
                    }        
                }
            }
            
            
        }

        public void loadLocations()
        {
            this.drpLocation.Items.Add("Please Select");
            foreach (Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
        }

        int[] Years;
        double[] avgValues;
        int arraySize;
        public void loadDetails()
        {
            foreach (Location l in Data.locations)
            {
                if (this.drpLocation.SelectedItem.ToString() == l.getLocationName())
                {
                    Year[] years = l.getYearlyObsv();
                    if (years != null)
                    {
                        foreach (Year y in years)
                        {
                            double temp = 0;
                            MonthlyObsv[] month = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in month)
                            {
                                double tempValue = m.GetMinTemp();

                                temp = temp + tempValue;
                            }

                            temp = temp / 12;
                            resizeTemp(temp);
                            resizeYears(y.GetYear());
                        }
                    }
                }
            }

            if (avgValues != null)
            {
                showDetails(avgValues);
            }
        }

        private void resizeTemp(double temp)
        {
            if (avgValues == null)
            {
                arraySize = 0;
            }
            else
            {
                arraySize = avgValues.Length;
            }
            Array.Resize(ref avgValues, arraySize + 1);

            temp = Math.Round(temp, 2);
            avgValues[arraySize] = temp;
        }

        private void resizeYears(int year)
        {
            if (Years == null)
            {
                arraySize = 0;
            }
            else
            {
                arraySize = Years.Length;
            }
            Array.Resize(ref Years, arraySize + 1);
            Years[arraySize] = year;
        }

        public void showDetails(double[] avgValues)
        {
            int minTempIndex = Array.IndexOf(avgValues, avgValues.Min());

            this.txtLocation.Text = this.drpLocation.SelectedItem.ToString();
            this.txtMinYear.Text = Years[minTempIndex] + ":\n" + avgValues.Min() + "°C";
            this.txtTotalYears.Text = Years.Length.ToString();
        }

        public void drawYAxis()
        {
            this.yAxis.Refresh();
            Graphics yAxis = this.yAxis.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 10, style3);
            double maxTemp = Math.Round(avgValues.Max()) + 1;
            int number = Convert.ToInt32(maxTemp / 1);

            int x = 0;
            int y = 0;


            for (int i = 0; i < number; i++)
            {
                yAxis.DrawString(maxTemp.ToString() + "°C", arial3, brush, x, y);

                maxTemp = maxTemp - 1;
                y = y + (this.yAxis.Height / number);
            }
        }

        public void drawXAxis()
        {
            this.xAxis.Refresh();
            Graphics xAxis = this.xAxis.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 10, style3);
            Font arial4 = new Font(new FontFamily("Arial"), 10, style3);

            int number = Years.Length;

            int x = this.xAxis.Width / 100;
            int y = 0;

            xAxis.DrawString(Years[0].ToString(), arial3, brush, x, y);
 
            xAxis.DrawString(Years[(Years.Length / 2) - 1].ToString(), arial3, brush, x * 50, y);
     
            xAxis.DrawString(Years[Years.Length - 1].ToString(), arial3, brush, x * 100 , y);
        }

        public void drawGraph()
        {
            this.pnlGraph.Refresh();
            Graphics graph = this.pnlGraph.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 11, style3);

            int gap = 10;
            int lengthArea = this.pnlGraph.Width - (avgValues.Length * gap);
            int heightArea = this.pnlGraph.Height;

            double maxWeight = Math.Round(avgValues.Max()) + 1;

            int x = 0;
            double y = 0;

            int length = (lengthArea / avgValues.Length);
            double height = 0;

            for (int i = 0; i < avgValues.Length; i++)
            {
                brush.Color = Color.LightBlue;
                height = ((avgValues[i] * heightArea) / maxWeight);
                y = heightArea - height;

                brush.Color = Color.Black;
                graph.DrawString("*".ToString(), arial3, brush, x, Convert.ToInt32(y));
                x = x + length + gap;
            }
        }
    }
    
}
