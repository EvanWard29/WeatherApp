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
    public partial class frmLocation : Form
    {
        public static frmLocation frmLoc = null;
        public frmLocation()
        {
            InitializeComponent();
            frmLoc = this;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain tempMain = new frmMain();
            tempMain.Show();
            frmLoc.Close();
        }

        private void btnSearchLoc_Click(object sender, EventArgs e)
        {
            frmSearchLoc tempSearchLoc = new frmSearchLoc();
            tempSearchLoc.Show();
            frmLoc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLocationEdit tempEditLoc = new frmLocationEdit();
            tempEditLoc.Show();
            frmLoc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddLocation tempAddLoc = new frmAddLocation();
            tempAddLoc.Show();
            frmLoc.Close();
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            frmLocationData tempData = new frmLocationData();
            tempData.Show();
            frmLoc.Close();
        }
    }
}
