using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SOFT152_Coursework2018
{
    public partial class frmAddData : Form
    {
        public static frmAddData frmAddYear = null;
        public frmAddData()
        {
            InitializeComponent();
            frmAddYear = this;
        }

        //Add location names to combo box
        public void setLocations()
        {
            foreach(Location l in Data.locations)
            {
                this.drpLocations.Items.Add(l.getLocationName());
            }
            this.drpLocations.SelectedIndex = 0;
        }

        private void frmAddData_Load(object sender, EventArgs e)
        {
            setLocations();
        }

        bool preventBack = false;
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(preventBack != true)
            {
                frmYearlyObsv tempYearlyObsv = new frmYearlyObsv();
                tempYearlyObsv.Show();
                frmAddYear.Close();
            }
            else
            {
                //Won't allow user to leave the page unless a full set of data has been added
                MessageBox.Show("You Cannot Leave Until 12 Months of Data Has Been Added", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        bool yearAdded = false;

        //Creates new year object
        public void createNewYear()
        {    
            int arraySize;
            string YearID, Comment, Location;

            YearID = this.txtYearID.Text;
            Comment = this.rtxtComment.Text;
            Location = this.drpLocations.SelectedItem.ToString();

            foreach (Location l in Data.locations)
            {
                if (Location == l.getLocationName())
                {
                    Year[] years = l.getYearlyObsv();
                    //Validates the year
                    if(validInput(YearID) != true)
                    {
                        //Checks to see if the year already exists
                        if (checkYear(years, YearID) != true)
                        {
                            DialogResult result = MessageBox.Show("Are You Sure You Want To Add The Year " + this.txtYearID.Text +
                                " To The Location " + this.drpLocations.SelectedItem.ToString() + "?", "Warning", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

                            //If user says yes, add the year to array
                            if (result == DialogResult.Yes)
                            {
                                Year tempYear = new Year(YearID, Comment, null);

                                if (years == null)
                                {
                                    arraySize = 0;
                                }
                                else
                                {
                                    arraySize = years.Length;
                                }
                                Array.Resize(ref years, arraySize + 1);
                                years[arraySize] = tempYear;
                                l.setYearlyObsv(years);

                                MessageBox.Show("Year Saved Successfully\nPlease Now Add 12 Months Of Data", "Attention", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                preventBack = true;
                                this.txtYearID.ReadOnly = true;
                                this.rtxtComment.ReadOnly = true;
                                this.txtMonthID.Text = "1";
                                yearAdded = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Have Already Created the Year " + YearID + "\nYou Must Add 12 Months Worth of Data", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }   
                }
            }  
        }

        public bool validInput(string YearID)
        {
            //Validates year input
            bool error = false;
            if(YearID == "")
            {
                MessageBox.Show("Cannot Leve Year Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;       
            }
            try
            {
                Convert.ToInt32(YearID);
            }
            catch (FormatException)
            {
                error = true;
            }
            return error;
        }

        //Verifies year input
        private bool checkYear(Year[] years, string YearID)
        {
            bool error = false;

            if (years == null)
            {
                return error;
            }
            else
            {
                foreach (Year y in years)
                {
                    if (YearID == y.GetYear().ToString())
                    {
                        error = true;
                        break;
                    }
                }
            }
            return error;
        }

        //Validates all field inputs
        public bool checkError(string MonthID, string MaxTemp, string MinTemp, string FrostDays, string AmountRain, string HrsSun)
        {
            bool error = false;

            string[] values = new string[] { MonthID, MaxTemp, MinTemp, FrostDays, AmountRain, HrsSun };

            foreach(string item in values)
            {
                if (item == "")
                {
                    MessageBox.Show("Cannot Leave Fields Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                    break;
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(item);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Enter Valid Data Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                        break;
                    }
                }  
            }
            return error;
        }

        //Creates new MonthlyObservations objects
        public void createNewMonth()
        {
            int arraySize;
            string YearID = this.txtYearID.Text;
            string Location = this.drpLocations.SelectedItem.ToString();
            string MonthID, MaxTemp, MinTemp, FrostDays, AmountRain, HrsSun;

            MonthID = this.txtMonthID.Text;
            MaxTemp = this.txtMaxTemp.Text;
            MinTemp = this.txtMinTemp.Text;
            FrostDays = this.txtFrostyDays.Text;
            AmountRain = this.txtAmountRain.Text;
            HrsSun = this.txtHrsSun.Text;

            bool save = true;
            
            //If no errors found
            if (checkError(MonthID, MaxTemp, MinTemp, FrostDays, AmountRain, HrsSun) != true)
            {
                foreach (Location l in Data.locations)
                {
                    if (Location == l.getLocationName())
                    {
                        Year[] years = l.getYearlyObsv();
                        foreach (Year y in years)
                        {
                            if (YearID == y.GetYear().ToString())
                            {
                                MonthlyObsv[] month = y.GetMonthlyObsv();

                                //Create new object
                                MonthlyObsv tempMonth = new MonthlyObsv(MonthID, MaxTemp, MinTemp, FrostDays, AmountRain, HrsSun);

                                //If array isn't empty
                                if(month != null)
                                {
                                    foreach(MonthlyObsv m in month)
                                    {
                                        //Cheacks to see if data for this mpnth already exists
                                        if(tempMonth.GetMonthID() == m.GetMonthID())
                                        {
                                            MessageBox.Show("Data for this Month Already Exists", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                            save = false;
                                            break;
                                        }   
                                    }
                                }

                                if (save != false)
                                {
                                    if(tempMonth.GetMonthID() > 12)
                                    {
                                        MessageBox.Show("Enter a Month ID Less Than 12", "Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        //If array empty, set array size
                                        if (month == null)
                                        {
                                            arraySize = 0;
                                        }
                                        else
                                        {
                                            arraySize = month.Length;
                                        }
                                        Array.Resize(ref month, arraySize + 1);
                                        month[arraySize] = tempMonth;

                                        //Set MontlhyObservation object
                                        y.SetMonthlyObsv(month);
                                        //Set YearlyObservation object
                                        l.setYearlyObsv(years);

                                        int num = Convert.ToInt32(this.txtMonthID.Text);
                                        num = num + 1;
                                        this.txtMonthID.Text = num.ToString();

                                        //If 12 months of data has been added
                                        if (num > 12)
                                        {
                                            //Allow user to go back to menu
                                            preventBack = false;
                                            //Confirm save
                                            MessageBox.Show("12 Months of Data Successfully Added", "Attention", MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                                            //Clears entry fields
                                            this.txtMonthID.Text = "";
                                            this.txtMaxTemp.Text = "";
                                            this.txtMinTemp.Text = "";
                                            this.txtFrostyDays.Text = "";
                                            this.txtAmountRain.Text = "";
                                            this.txtHrsSun.Text = "";
                                            saveData();
                                        }
                                        else
                                        {
                                            //Clears entry fields
                                            this.txtMaxTemp.Text = "";
                                            this.txtMinTemp.Text = "";
                                            this.txtFrostyDays.Text = "";
                                            this.txtAmountRain.Text = "";
                                            this.txtHrsSun.Text = "";
                                        }
                                    }   
                                }
                            }
                        }
                    }
                }
            }      
        }

        //Saves new data to file
        public void saveData()
        {
            //Get filename
            selectFile.ShowDialog();
            string fileName = selectFile.FileName;

            StreamWriter file = new StreamWriter(fileName);
            file.WriteLine(Data.locations.Length);

            //Go through array and write to file line by line
            foreach (Location l in Data.locations)
            {
                file.WriteLine(l.getLocationName());
                file.WriteLine(l.getStreetNumName());
                file.WriteLine(l.getCounty());
                file.WriteLine(l.getPostcode());
                file.WriteLine(l.getLatitude());
                file.WriteLine(l.getLongitude());

                Year[] years = l.getYearlyObsv();
                file.WriteLine(years.Length);
                foreach (Year y in years)
                {

                    file.WriteLine(y.GetComment());
                    file.WriteLine(y.GetYear());
                    int month = 1;
                    MonthlyObsv[] months = y.GetMonthlyObsv();
                    foreach (MonthlyObsv m in months)
                    {
                        file.WriteLine(m.GetMonthID());
                        file.WriteLine(m.GetMaxTemp());
                        file.WriteLine(m.GetMinTemp());
                        file.WriteLine(m.GetNumDaysAirFrost());
                        file.WriteLine(m.GetAmountOfRain());
                        file.WriteLine(m.GetHrsOfSun());
                        if (month != 12)
                        {
                            file.WriteLine(y.GetYear());
                        }
                        month++;

                    }
                }
            }
            file.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {   
            if(yearAdded == true)
            {
                createNewMonth();
            }
            else
            {
                MessageBox.Show("Before Adding Monthly Data You Must Add a New Year", "Attentio", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            createNewYear();
        }
    }
}
