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
    public partial class frmYearlyObsv : Form
    {
        public static frmYearlyObsv frmYear = null;
        public frmYearlyObsv()
        {
            InitializeComponent();
            frmYear = this;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            frmYearData tempYear = new frmYearData();
            tempYear.Show();
            frmYear.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain tempMain = new frmMain();
            tempMain.Show();
            frmYear.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditYear tempEditYear = new frmEditYear();
            tempEditYear.Show();
            frmYear.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddData tempAddYear = new frmAddData();
            tempAddYear.Show();
            frmYear.Close();
        }

        private void btnSelectMax_Click(object sender, EventArgs e)
        {
            frmAverageMaxTemp tempAvg = new frmAverageMaxTemp();
            tempAvg.Show();
            frmYear.Close();
        }

        private void btnSelectMin_Click(object sender, EventArgs e)
        {
            frmAverageMinTemp tempMin = new frmAverageMinTemp();
            tempMin.Show();
            frmYear.Close();
        }

        private void btnSelectRain_Click(object sender, EventArgs e)
        {
            frmAmountRain tempRain = new frmAmountRain();
            tempRain.Show();
            frmYear.Close();
        }

        private void btnSelectSun_Click(object sender, EventArgs e)
        {
            frmAverageHrsSun tempSun = new frmAverageHrsSun();
            tempSun.Show();
            frmYear.Close();
        }

        private void btnSelectFrost_Click(object sender, EventArgs e)
        {
            frmAverageFrost tempFrost = new frmAverageFrost();
            tempFrost.Show();
            frmYear.Close();
        }
    }
}
