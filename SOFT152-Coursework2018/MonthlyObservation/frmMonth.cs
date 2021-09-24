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
    public partial class frmMonth : Form
    {
        public static frmMonth frmMonthlyObservations = null;
        public frmMonth()
        {
            InitializeComponent();
            frmMonthlyObservations = this;
        }

        private void btnMonthID_Click(object sender, EventArgs e)
        {
            frmMonthID tempMonthID = new frmMonthID();
            tempMonthID.Show();
            frmMonthlyObservations.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain tempMain = new frmMain();
            tempMain.Show();
            frmMonthlyObservations.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMaxTemp frmTemp = new frmMaxTemp();
            frmTemp.Show();
            frmMonthlyObservations.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditMonth tempEditMonth = new frmEditMonth();
            tempEditMonth.Show();
            frmMonthlyObservations.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinTemp_Click(object sender, EventArgs e)
        {
            frmMinTemp frmMinGraph = new frmMinTemp();
            frmMinGraph.Show();
            frmMonthlyObservations.Close();
        }

        private void btnAmountRain_Click(object sender, EventArgs e)
        {
            MonthlyObservation.frmAmountRain tempAmountRain = new MonthlyObservation.frmAmountRain();
            tempAmountRain.Show();
            frmMonthlyObservations.Close();
        }

        private void BtnFrostDays_Click(object sender, EventArgs e)
        {
            frmFrostyDays tempFrost = new frmFrostyDays();
            tempFrost.Show();
            frmMonthlyObservations.Close();
        }

        private void btnHrsSun_Click(object sender, EventArgs e)
        {
            frmHrsSun tempSun = new frmHrsSun();
            tempSun.Show();
            frmMonthlyObservations.Close();
        }
    }
}
