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
    public partial class frmAverageMaxTemp : Form
    {
        public static frmAverageMaxTemp frmAvgMax = null;

        double[] avgValues;
        public frmAverageMaxTemp()
        {
            InitializeComponent();
            frmAvgMax = this;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmYearlyObsv tempYear = new frmYearlyObsv();
            tempYear.Show();
            frmAvgMax.Close();
        }      

        

        private void frmAverageMaxTemp_Load(object sender, EventArgs e)
        {
            loadLocations();
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
        int arraySize;
        //Get YearlyObservations for selected location
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
                            if (y != null)
                            {
                                double temp = 0;
                                MonthlyObsv[] month = y.GetMonthlyObsv();
                                foreach (MonthlyObsv m in month)
                                {
                                    double tempValue = m.GetMaxTemp();

                                    temp = temp + tempValue;
                                }
                                //Calculate average for year
                                temp = temp / 12;
                                resizeTemp(temp);
                                resizeYears(y.GetYear());
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Data for " + this.drpLocation.SelectedItem.ToString() + " Could Not Be Found.\n" +
                                    "To Add Data Click OK", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                                if (result == DialogResult.OK)
                                {
                                    frmAddData tempYearData = new frmAddData();
                                    tempYearData.Show();
                                    frmAvgMax.Close();
                                }
                            }
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
            //Adds avergae value to array
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
            //Adds year value to array
            if(Years == null)
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

        //Show location details
        public void showDetails(double[] avgValues)
        {
            if (avgValues != null)
            {
                int maxTempIndex = Array.IndexOf(avgValues, avgValues.Max());

                this.txtLocation.Text = this.drpLocation.SelectedItem.ToString();
                //Get Maximum average temperature
                this.txtMaxYear.Text = Years[maxTempIndex] + ":\n" + avgValues.Max() + "°C";
                //Number of years for location
                this.txtTotalYears.Text = Years.Length.ToString();
            }
        }

        private void yAxis_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void drawYAxis()
        {
            if (avgValues != null)
            {
                //Clear panel
                this.yAxis.Refresh();
                Graphics yAxis = this.yAxis.CreateGraphics();

                //Create new brush
                SolidBrush brush = new SolidBrush(Color.Black);

                //Create new font style
                FontStyle style3 = FontStyle.Bold;
                Font arial3 = new Font(new FontFamily("Arial"), 10, style3);

                //Get highest value in array for year
                double maxTemp = Math.Round(avgValues.Max()) + 1;
                //Set differenece between each value on yAxis
                int number = Convert.ToInt32(maxTemp / 1);

                int x = 0;
                int y = 0;


                for (int i = 0; i < number; i++)
                {
                    //Draw value to panel
                    yAxis.DrawString(maxTemp.ToString() + "°C", arial3, brush, x, y);

                    //Calculates position for next value
                    maxTemp = maxTemp - 1;
                    y = y + (this.yAxis.Height / number);
                }
            }
            else
            {

            }
        }

        private void xAxis_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void drawXAxis()
        {
            if (Years != null)
            {
                //Clears panel
                this.xAxis.Refresh();
                Graphics xAxis = this.xAxis.CreateGraphics();
                SolidBrush brush = new SolidBrush(Color.Black);

                FontStyle style3 = FontStyle.Bold;
                Font arial3 = new Font(new FontFamily("Arial"), 10, style3);
                Font arial4 = new Font(new FontFamily("Arial"), 10, style3);

                int number = Years.Length;

                int x = 7;
                int y = 0;

                for (int i = 0; i < Years.Length; i++)
                {
                    //If there are more than 50 years in location
                    if (Years.Length > 50)
                    {
                        //Draw Year every 5 spaces on panel
                        if (i % 5 == 0)
                        {
                            xAxis.DrawString(Years[i].ToString(), arial3, brush, x, y);
                        }
                    }
                    else
                    {
                        //Else draw year every 2 spaces on panel
                        if (i % 2 == 0)
                        {
                            xAxis.DrawString(Years[i].ToString(), arial4, brush, x, y);
                        }
                    }

                    x = x + (this.xAxis.Width / number);

                }
            }
            else
            {

            }
        }

        public void drawGraph()
        {
            //Clears panel
            this.pnlGraph.Refresh();
            Graphics graph = this.pnlGraph.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 11, style3);

            //Length between each value
            int gap = 10;
            //Calculates the needed length to fit all values on panel
            int lengthArea = this.pnlGraph.Width - (avgValues.Length * gap);
            int heightArea = this.pnlGraph.Height;

            //Get highest value
            double maxWeight = Math.Round(avgValues.Max()) + 1;

            int x = 0;
            double y = 0;

            //Set position for values to start
            int length = (lengthArea / avgValues.Length);
            double height = 0;

            for (int i = 0; i < avgValues.Length; i++)
            {
                //Get position for value to be placed on yAxis
                brush.Color = Color.LightBlue;
                height = ((avgValues[i] * heightArea) / maxWeight);
                y = heightArea - height;

                //Draw value to panel
                brush.Color = Color.Black;
                //Represent value with "*"
                graph.DrawString("*".ToString(), arial3, brush, x, Convert.ToInt32(y));  
                //Set position of next value
                x = x + length + gap;
            }
        }

        private void drpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.drpLocation.SelectedIndex != 0)
            {
                avgValues = null;
                Years = null;
                loadDetails();

                drawYAxis();
                drawXAxis();

                //If location chnages and array isn't empty
                if (avgValues != null)
                {
                    drawGraph();
                }
                //If array is empty
                else
                {
                    this.pnlGraph.Refresh();

                    //Prompt user to add new data
                    DialogResult result = MessageBox.Show("No Data Could be Found for the Location " +
                        this.drpLocation.SelectedItem.ToString() + ".\nWould you Like to Add Data?", "Error",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if(result == DialogResult.Yes)
                    {
                        frmAddData tempFrmData = new frmAddData();
                        tempFrmData.Show();
                        frmAvgMax.Close();
                    }
                }
            }
            
        }
    }
}
