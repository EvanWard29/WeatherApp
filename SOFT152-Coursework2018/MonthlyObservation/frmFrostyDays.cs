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
    public partial class frmFrostyDays : Form
    {
        public static frmFrostyDays frmFrost = null;
        public frmFrostyDays()
        {
            InitializeComponent();
            frmFrost = this;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMonth tempMonth = new frmMonth();
            tempMonth.Show();
            frmFrost.Close();
        }

        private void yAxis_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            FontStyle style3 = FontStyle.Bold;
            Font arial3 = new Font(new FontFamily("Arial"), 11, style3);
            int maxTemp = 30;
            int number = maxTemp / 2;

            int x = 0;
            int y = 0;


            for (int i = 0; i < number; i++)
            {
                e.Graphics.DrawString(maxTemp.ToString(), arial3, brush, x, y);

                maxTemp = maxTemp - 2;
                y = y + (this.yAxis.Height / number);
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

        private void frmFrostyDays_Load(object sender, EventArgs e)
        {
            loadLocations();
        }

        public void loadLocations()
        {
            foreach (Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
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
                    frmFrost.Close();
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        double[] frostValues = new double[12];
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
                                double temp = m.GetNumDaysAirFrost();
                                frostValues[i] = temp;
                                i++;
                            }
                        }
                    }
                }
            }
            int maxFrostIndex = Array.IndexOf(frostValues, frostValues.Max());
            double maxFrost = frostValues.Max();
 
            string highMonth = months[maxFrostIndex];  
            
            showDetails(highMonth, maxFrost, frostValues);
        }

        public void showDetails(string highMonth, double maxFrost, double[] frostValues)
        {
            this.txtLocation.Text = this.drpLocation.SelectedItem.ToString();
            this.txtYearID.Text = this.txtYear.Text;
            this.txtHighestMonth.Text = highMonth + ":\n" + maxFrost + " Days";
            this.txtTotal.Text = frostValues.Sum().ToString();
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
            int lengthArea = this.pnlGraph.Width - (frostValues.Length * gap);
            int heightArea = this.pnlGraph.Height;

            double maxWeight = 30;

            int x = 0;
            double y = 0;

            int length = (lengthArea / 12);
            double height = 0;

            for (int i = 0; i < 12; i++)
            {
                brush.Color = Color.LightBlue;
                height = ((frostValues[i] * heightArea) / maxWeight);
                y = heightArea - height;

                Rectangle rect = new Rectangle(x, Convert.ToInt32(y), length, Convert.ToInt32(height));
                graph.DrawRectangle(pen, rect);
                graph.FillRectangle(brush, rect);

                brush.Color = Color.Black;
                graph.DrawString(frostValues[i].ToString(), arial3, brush, x, Convert.ToInt32(y));
                graph.DrawRectangle(pen, rect);
                x = x + length + gap;
            }
        }
    }
}
