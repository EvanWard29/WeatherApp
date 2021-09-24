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
    public partial class frmAddLocation : Form
    {
        public static frmAddLocation frmAddLoc = null;
        public frmAddLocation()
        {
            InitializeComponent();
            frmAddLoc = this;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLocation tempLoc = new frmLocation();
            tempLoc.Show();
            frmAddLoc.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInputs() == false)
            {
                if (checkExists() == false)
                {
                    addLocation();
                }
            }
        }

        public bool checkInputs()
        {
            string name = this.txtName.Text;
            string street = this.txtStreet.Text;
            string county = this.txtCounty.Text;
            string postcode = this.txtPostcode.Text;
            string longitude = this.txtLat.Text;
            string latitude = this.txtLong.Text;

            string[] details = new string[] { name, street, county, postcode, longitude, latitude };

            foreach(string detail in details)
            {
                if(detail == "")
                {
                    MessageBox.Show("Cannot Leave Fields Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        public bool checkExists()
        {
            string name = this.txtName.Text;

            foreach(Location l in Data.locations)
            {
                if(name == l.getLocationName())
                {
                    MessageBox.Show("The Location " + name + " Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        public void addLocation()
        {
            string name = this.txtName.Text;
            string street = this.txtStreet.Text;
            string county = this.txtCounty.Text;
            string postcode = this.txtPostcode.Text;
            string longitude = this.txtLat.Text;
            string latitude = this.txtLong.Text;
            int arraySize;

            if(checkCoords(longitude,latitude) == true)
            {
                Location tempLocation = new Location(name, street, county, postcode, latitude, longitude);

                if(Data.locations == null)
                {
                    arraySize = 0;
                }
                else
                {
                    arraySize = Data.locations.Length;
                }
                Array.Resize(ref Data.locations, arraySize + 1);
                Data.locations[arraySize] = tempLocation;

                saveFile();           
            }
        }

        public void saveFile()
        {
            selectFile.ShowDialog();
            string fileName = selectFile.FileName;

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
                if (years != null)
                {
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
            }
            file.Close();
            MessageBox.Show("Location Added Successfully", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool checkCoords(string longitude, string latitude)
        {
            try
            {
                Double.Parse(longitude);
                Double.Parse(latitude);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invlaid Data Type For Latitude or Longitude", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void frmAddLocation_Load(object sender, EventArgs e)
        {

        }

        
    }
}
