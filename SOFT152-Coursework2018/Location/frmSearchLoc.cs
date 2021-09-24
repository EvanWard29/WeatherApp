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
    public partial class frmSearchLoc : Form
    {
        public static frmSearchLoc frmSearchLocation = null;
        public frmSearchLoc()
        {
            InitializeComponent();
            frmSearchLocation = this;       
        }

        public void searchLocation()
        {
            string locationName = this.txtLocation.Text;
            bool found = false;
            if (locationName == "")
            {
                MessageBox.Show("Enter a Location Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Location l in Data.locations)
                {
                    if (locationName == l.getLocationName())
                    {
                        found = true;                 
                        ShowLocation(l);
                    }
                }
                if (found != true)
                {
                    MessageBox.Show("Location Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }

        private void ShowLocation(Location l)
        {
            this.txtLocName.Text = l.getLocationName();
            this.txtStreet.Text = l.getStreetNumName();
            this.txtCounty.Text = l.getCounty();
            this.txtPostcode.Text = l.getPostcode();
            this.txtLatitude.Text = l.getLongitude().ToString();
            this.txtLongitude.Text = l.getLatitude().ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchLocation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLocation tempLoc = new frmLocation();
            tempLoc.Show();
            frmSearchLocation.Close();
        }
        
        private void frmSearchLoc_Load(object sender, EventArgs e)
        {
            
        }
    }
}
