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
    public partial class frmEditYear : Form
    {
        public static frmEditYear frmYearEdit = null;
        public frmEditYear()
        {
            InitializeComponent();
            frmYearEdit = this;
        }

        private void grpDetails_Enter(object sender, EventArgs e)
        {

        }

        private void frmEditYear_Load(object sender, EventArgs e)
        {
            foreach(Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmYearlyObsv tempYearlyObsv = new frmYearlyObsv();
            tempYearlyObsv.Show();
            frmYearEdit.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchYear();
        }

        //Check to see if year exists
        public void searchYear()
        {
            bool found = false;
            bool noData = false;

            this.txtLocationID.Text = "";
            this.txtYearID.Text = "";
            this.rtxtDescription.Text = "";

            if (validateInput() != true)
            {
                foreach (Location l in Data.locations)
                {
                    if (l.getLocationName() == this.drpLocation.SelectedItem.ToString())
                    {
                        Year[] year = l.getYearlyObsv();
                        if (year != null)
                        {
                            foreach (Year y in year)
                            {
                                if (y.GetYear() == Convert.ToInt32(this.txtSelectYear.Text))
                                {
                                    this.txtLocationID.Text = l.getLocationName();
                                    this.txtYearID.Text = y.GetYear().ToString();
                                    this.rtxtDescription.Text = y.GetComment();

                                    found = true;                                  
                                }
                            }
                            
                        }
                        else
                        {
                            noData = true;
                        }
                    }
                }
                //If no data for year exists, add new data
                if (found == false && noData == true)
                {
                    DialogResult result = MessageBox.Show("There was no Data Found for the Location " + this.drpLocation.SelectedItem.ToString()
                    + ".\nWould you Like to Add Data?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        frmAddData tempAddData = new frmAddData();
                        tempAddData.Show();
                        frmYearEdit.Close();
                    }
                }
                else if (found == false)
                {
                    MessageBox.Show("Year Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }    
        }

        public bool validateInput()
        {
            bool error = false;

            try
            {
                Convert.ToInt32(this.txtSelectYear.Text);
            }
            catch (FormatException)
            {
                if (this.txtSelectYear.Text == "")
                {
                    MessageBox.Show("Enter A Year To Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Enter Valid Data Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                error = true;
            }
            return error;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Save?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                if(this.rtxtDescription.Text != "")
                {
                    updateArray();
                    updateFile();
                }       
                else
                {
                    MessageBox.Show("Cannot Leave Description Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        //Add edited details to array
        public void updateArray()
        {
            string locationName = this.txtLocationID.Text;
            string yearID = this.txtYearID.Text;
            string comment = this.rtxtDescription.Text;

            foreach (Location l in Data.locations)
            {
                if (l.getLocationName() == locationName)
                {
                    Year[] year = l.getYearlyObsv();
                    foreach (Year y in year)
                    {
                        if (y.GetYear() == Convert.ToInt32(yearID))
                        {
                            y.SetComment(comment);
                        }
                    }
                }
            }  
        }

        //Save array to file 
        public void updateFile()
        {
            selectFile.ShowDialog();
            string fileName = selectFile.FileName;

            if(fileName != "SelectFile")
            {
                StreamWriter file = new StreamWriter(fileName);
                file.WriteLine(Data.locations.Length);

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
                MessageBox.Show("Description Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You Must Select a File to Update or Enter A New FileName", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            
            
        }

        private void grpYear_Enter(object sender, EventArgs e)
        {

        }
    }
}
