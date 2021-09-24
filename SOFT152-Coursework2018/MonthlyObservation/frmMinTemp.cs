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
    public partial class frmMinTemp : Form
    {
        public static frmMinTemp frmMinGraph = null;
        public frmMinTemp()
        {
            InitializeComponent();
            frmMinGraph = this;
        }


        public void loadLocations()
        {
            foreach (Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
        }

        private void frmMinTemp_Load(object sender, EventArgs e)
        {
            loadLocations();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (checkInput() != true)
            {
                if (checkExist() != false)
                {
                    loadDetails();
                    drawGraph();
                }
            }

        }

        public bool checkInput()
        {
            if (this.txtYear.Text == "")
            {
                MessageBox.Show("Enter a Year To See Results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            try
            {
                Convert.ToInt32(this.txtYear.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter A Valid Data Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public bool checkExist()
        {
            bool noData = false;
            foreach (Location l in Data.locations)
            {
                if (l.getLocationName() == this.drpLocation.SelectedItem.ToString())
                {
                    Year[] years = l.getYearlyObsv();
                    if (years != null)
                    {
                        foreach (Year y in years)
                        {
                            if (this.txtYear.Text == y.GetYear().ToString())
                            {
                                return true;
                            }
                        }
                    }
                    else
                    {
                        noData = true;
                    }
                }
            }
            if (noData != true)
            {
                MessageBox.Show("The Year " + this.txtYear.Text + " Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                DialogResult result = MessageBox.Show("There was no Data Found for the Location " + this.drpLocation.SelectedItem.ToString()
                    + ".\nWould you Like to Add Data?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    frmAddData tempAddData = new frmAddData();
                    tempAddData.Show();
                    frmMinGraph.Close();
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        double[] tempValues = new double[12];
        public void loadDetails()
        {
            string[] months = new string[12] {"January","February","March","April","May","June","July","August","September",
            "October","November","Decemebr"};


            int i = 0;

            foreach (Location l in Data.locations)
            {
                if (this.drpLocation.SelectedItem.ToString() == l.getLocationName())
                {
                    Year[] years = l.getYearlyObsv();
                    foreach (Year y in years)
                    {
                        if (this.txtYear.Text == y.GetYear().ToString())
                        {
                            MonthlyObsv[] month = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in month)
                            {
                                double temp = m.GetMinTemp();
                                tempValues[i] = temp;
                                i++;
                            }
                        }
                    }
                }
            }
            int minTempIndex = Array.IndexOf(tempValues, tempValues.Min());
            double minTemp = tempValues.Min();
            double maxTemp = tempValues.Max();
            string coldMonth = months[minTempIndex];
            showDetails(coldMonth, maxTemp, minTemp, tempValues);
        }

        public void showDetails(string coldMonth, double maxTemp, double minTemp, double[] tempValues)
        {
            this.txtLocation.Text = this.drpLocation.SelectedItem.ToString();
            this.txtYearID.Text = this.txtYear.Text;
            this.txtColdMonth.Text = coldMonth;
            this.txtMaxTemp.Text = maxTemp.ToString() + "°C";
            this.txtMinTemp.Text = minTemp.ToString() + "°C";
        }

        public void drawGraph()
        {
            this.pnlGraph.Refresh();
            Graphics graph = this.pnlGraph.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 9, style3);

            int gap = 10;
            int lengthArea = this.pnlGraph.Width - (tempValues.Length * gap);
            int heightArea = (this.pnlGraph.Height/5)*4; //Y Coord of 0 on graph

            double maxWeight = 20;

            int x = 0;
            double y = 0;

            int length = (lengthArea / 12);
            double height = 0;

            for (int i = 0; i < 12; i++)
            {
                brush.Color = Color.LightBlue;
                height = ((tempValues[i] * heightArea) / maxWeight);
                y = heightArea - height;

                Rectangle rect = new Rectangle();
                if (height <= 0)
                {
                    rect = new Rectangle(x, Convert.ToInt32(y), length, Convert.ToInt32(y - height));
                }
                else
                {
                    rect = new Rectangle(x, Convert.ToInt32(y), length, Convert.ToInt32(height + (this.pnlGraph.Height - height)));
                }
                graph.DrawRectangle(pen, rect);
                graph.FillRectangle(brush, rect);

                brush.Color = Color.Black;
                graph.DrawString(tempValues[i] + "°C".ToString(), arial3, brush, x, Convert.ToInt32(y));
                graph.DrawRectangle(pen, rect);
                x = x + length + gap;
            }
        }

        private void xAxis_Paint(object sender, PaintEventArgs e)
        {
            string[] months = new string[] {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct",
            "Nov","Dec" };

            SolidBrush brush = new SolidBrush(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 12, style3);

            int number = 12;

            int x = 7;
            int y = 0;

            for (int i = 0; i < 12; i++)
            {
                e.Graphics.DrawString(months[i], arial3, brush, x, y);

                x = x + (this.xAxis.Width / number);
            }
        }

        private void yAxis_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 10, style3);

            int number = 5;

            int x = 0;
            int y = 0;
            int maxTemp = 20;

            for (int i = 0; i < number; i++)
            {
                e.Graphics.DrawString(maxTemp.ToString() + "°C", arial3, brush, x, y);

                maxTemp = maxTemp - 5;
                y = y + (this.yAxis.Height / number);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMonth tempMonth = new frmMonth();
            tempMonth.Show();
            frmMinGraph.Close();
        }

        

        
    }  
}
