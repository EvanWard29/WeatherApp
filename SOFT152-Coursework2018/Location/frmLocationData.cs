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
    public partial class frmLocationData : Form
    {
        public static frmLocationData frmLocData = null;
        public frmLocationData()
        {
            InitializeComponent();
            frmLocData = this;
        }

        bool locationChange;
        private void drpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationChange = true;
            getData(locationChange);

            getValues();
        }

        private void frmLocationData_Load(object sender, EventArgs e)
        {
            setRows();
            loadLocations();
        }

        public void setRows()
        {
            this.dgvByYear.RowCount = 12;

            for (int i = 0; i < 12; i++)
            {
                this.dgvByYear[0, i].Value = i + 1;
            }
        }

        public void loadLocations()
        {
            foreach (Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLocation tempLoc = new frmLocation();
            tempLoc.Show();
            frmLocData.Close();
        }

        public void getData(bool locationChnage)
        {
            string location = this.drpLocation.SelectedItem.ToString();
            int row = 0;

            foreach (Location l in Data.locations)
            {
                if (location == l.getLocationName())
                {
                    if (locationChange == true)
                    {
                        this.drpYearID.Items.Clear();
                        loadYears(l);
                    }


                    Year[] years = l.getYearlyObsv();
                    if (years != null)
                    {
                        foreach (Year y in years)
                        {
                            if (this.drpYearID.SelectedItem.ToString() == y.GetYear().ToString())
                            {
                                MonthlyObsv[] month = y.GetMonthlyObsv();
                                foreach (MonthlyObsv m in month)
                                {
                                    showData(m, row);
                                    row++;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DrpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void loadYears(Location l)
        {
            Year[] years = l.getYearlyObsv();
            if (years != null)
            {
                foreach (Year y in years)
                {
                    if (y != null)
                    {
                        this.drpYearID.Items.Add(y.GetYear());
                    }
                }
                this.drpYearID.SelectedIndex = 0;
            }
        }

        private void showData(MonthlyObsv m, int row)
        {
            this.dgvByYear[1, row].Value = m.GetMaxTemp() + "°C";
            this.dgvByYear[2, row].Value = m.GetMinTemp() + "°C";
            this.dgvByYear[3, row].Value = m.GetNumDaysAirFrost();
            this.dgvByYear[4, row].Value = m.GetAmountOfRain() + "mm";
            this.dgvByYear[5, row].Value = m.GetHrsOfSun();
        }

        private void drpYearID_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationChange = false;
            getData(locationChange);
        }

        double[] AvgMaxTemp;
        double[] AvgMinTemp;
        double[] AvgFrostDays;
        double[] AvgAmountRain;
        double[] AvgHrsSun;

        public void getValues()
        {
            string location = this.drpLocation.SelectedItem.ToString();
            int arraySize = 0;


            foreach (Location l in Data.locations)
            {
                if (location == l.getLocationName())
                {
                    Year[] year = l.getYearlyObsv();
                    if (year != null)
                    {
                        foreach (Year y in year)
                        {
                            double maxTemp = 0;
                            double minTemp = 0;
                            double frostDays = 0;
                            double amountRain = 0;
                            double hrsSun = 0;

                            MonthlyObsv[] month = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in month)
                            {
                                double tempMaxTemp = m.GetMaxTemp();
                                double tempMinTemp = m.GetMinTemp();
                                double tempFrostDays = m.GetNumDaysAirFrost();
                                double tempAmountRain = m.GetAmountOfRain();
                                double tempHrsSun = m.GetHrsOfSun();

                                maxTemp = maxTemp + tempMaxTemp;
                                minTemp = minTemp + tempMinTemp;
                                frostDays = frostDays + tempFrostDays;
                                amountRain = amountRain + tempAmountRain;
                                hrsSun = hrsSun + tempHrsSun;
                            }
                            getAverages(maxTemp, minTemp, frostDays, amountRain, hrsSun, arraySize);
                            arraySize++;
                        }
                    }
                }
            }

            createRows(arraySize);
            showAverages();

        }

        public void noData()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 1; j < 5; j++)
                {   
                    this.dgvByYear[j, i].Value = "NO DATA";
                }
            }

            for (int c = 0; c < 6; c++)
            {
                this.dgvByAverages[c, 0].Value = "NO DATA";
            }

            DialogResult result = MessageBox.Show("No Data Found for the Location " + this.drpLocation.SelectedItem.ToString() +
                ".\nWould You Like to Add Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                frmAddData tempYearData = new frmAddData();
                tempYearData.Show();
                frmLocData.Close();
            }
        }

        private void getAverages(double maxTemp, double minTemp, double frostDays, double amountRain, double hrsSun, int arraySize)
        {
            maxTemp = maxTemp / 12;
            minTemp = minTemp / 12;
            frostDays = frostDays / 12;
            amountRain = amountRain / 12;
            hrsSun = hrsSun / 12;

            addArray(maxTemp, minTemp, frostDays, amountRain, hrsSun, arraySize);
        }

        private void addArray(double maxTemp, double minTemp, double frostDays, double amountRain, double hrsSun, int arraySize)
        {

            Array.Resize(ref AvgMaxTemp, arraySize + 1);
            Array.Resize(ref AvgMinTemp, arraySize + 1);
            Array.Resize(ref AvgFrostDays, arraySize + 1);
            Array.Resize(ref AvgAmountRain, arraySize + 1);
            Array.Resize(ref AvgHrsSun, arraySize + 1);

            AvgMaxTemp[arraySize] = Math.Round(maxTemp, 2);
            AvgMinTemp[arraySize] = Math.Round(minTemp, 2);
            AvgFrostDays[arraySize] = Math.Round(frostDays, 2);
            AvgAmountRain[arraySize] = Math.Round(amountRain, 2);
            AvgHrsSun[arraySize] = Math.Round(hrsSun, 2);
        }

        public void createRows(int arraySize)
        {
            if (arraySize != 0)
            { 
                this.dgvByAverages.RowCount = arraySize;
            }
            else
            {
                this.dgvByAverages.RowCount = 1;
            }
        }

        public void showAverages()
        {
            foreach(Location l in Data.locations)
            {
                if(this.drpLocation.SelectedItem.ToString() == l.getLocationName())
                {
                    Year[] year = l.getYearlyObsv();
                    if (year != null)
                    {
                        for (int i = 0; i < year.Length; i++)
                        {
                            this.dgvByAverages[0, i].Value = year[i].GetYear();
                            this.dgvByAverages[1, i].Value = AvgMaxTemp[i] + "°C";
                            this.dgvByAverages[2, i].Value = AvgMinTemp[i] + "°C";
                            this.dgvByAverages[3, i].Value = AvgFrostDays[i];
                            this.dgvByAverages[4, i].Value = AvgAmountRain[i] + "mm";
                            this.dgvByAverages[5, i].Value = AvgHrsSun[i] + " Hrs";
                        }
                    }
                    else
                    {
                        noData();
                    }
                }
            }
        }
    }
}
