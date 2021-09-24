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
    public partial class frmLocationEdit : Form
    {
        public static frmLocationEdit frmEditLoc = null;
        public frmLocationEdit()
        {
            InitializeComponent();
            frmEditLoc = this;
        }

        public void loadLocations()
        {
            foreach(Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
        }

        private void frmLocationEdit_Load(object sender, EventArgs e)
        {
            loadLocations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLocation tempLoc = new frmLocation();
            tempLoc.Show();
            frmEditLoc.Close();
        }

        public void getLocation()
        {
            string location = this.drpLocation.SelectedItem.ToString();

            foreach(Location l in Data.locations)
            {
                if(location == l.getLocationName())
                {
                    this.txtLocationName.Text = l.getLocationName();
                    this.txtStreet.Text = l.getStreetNumName();
                    this.txtCounty.Text = l.getCounty();
                    this.txtPostcode.Text = l.getPostcode();
                    this.txtLong.Text = l.getLongitude().ToString();
                    this.txtLat.Text = l.getLatitude().ToString();
                }
            }
        }

        private void drpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            getLocation();
        }

        public void updateArray()
        {
            string location = this.txtLocationName.Text;

            foreach(Location l in Data.locations)
            {
                if(location == l.getLocationName())
                {
                    try
                    {
                        l.setStreetNumName(this.txtStreet.Text);
                        l.setCounty(this.txtCounty.Text);
                        l.setPostcode(this.txtPostcode.Text);
                        l.setLongitude(this.txtLong.Text);
                        l.setLatitude(this.txtLat.Text);

                        saveFile();
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        public void saveFile()
        {
            selectFile.ShowDialog();
            string fileName = selectFile.FileName;

            if (fileName != "SelectFile")
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
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You Must Select a File to Update or Enter A New FileName", "Warning", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Save These Changes?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                updateArray();
            }
        }
    }
}
