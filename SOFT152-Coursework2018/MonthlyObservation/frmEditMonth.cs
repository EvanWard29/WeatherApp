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
    public partial class frmEditMonth : Form
    {
        public static frmEditMonth FrmEditMonth = null;
        public frmEditMonth()
        {
            InitializeComponent();
            FrmEditMonth = this;
        }

        bool dataAdded = false;

        public void addRows()
        {
            this.dgvMonthlyObsv.RowCount = 12;
            for (int i = 0; i < 12; i++)
            {
                this.dgvMonthlyObsv[0, i].Value = i + 1;
            }

            for (int r = 0; r < this.dgvMonthlyObsv.RowCount; r++)
            {
                for (int c = 1; c < 6; c++)
                {
                    this.dgvMonthlyObsv[c, r].Value = "NO DATA";
                }
            }
            dataAdded = false;
        }

        public void addLocation()
        {
            foreach(Location l in Data.locations)
            {
                this.drpLocation.Items.Add(l.getLocationName());
            }
            this.drpLocation.SelectedIndex = 0;
        }

        public void searchYear()
        {
            if(checkInputError() != true)
            {
                if (checkYearExist() != false)
                {
                    addData();
                }
                else
                {
                    DialogResult result = MessageBox.Show("There was no Data Found for the Location " + this.drpLocation.SelectedItem.ToString()
                    + ".\nWould you Like to Add Data?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        frmAddData tempAddData = new frmAddData();
                        tempAddData.Show();
                        FrmEditMonth.Close();
                    }
                }
            }
        }

        public bool checkInputError()
        {
            if(this.txtYear.Text == "")
            {
                MessageBox.Show("Cannot Leave Year Field Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            try
            {
                Convert.ToInt32(this.txtYear.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid Data Type for Year","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public bool checkYearExist()
        {
            foreach (Location l in Data.locations)
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
                    return false;
                }
            }
            
            for (int r = 0; r < this.dgvMonthlyObsv.RowCount; r++)
            {
                for (int c = 1; c < 6; c++)
                {
                    this.dgvMonthlyObsv[c, r].Value = "NO DATA";
                }
            }
            MessageBox.Show("The Year " + this.txtYear.Text + " Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataAdded = false;
            return false;
        }
     
        public void addData()
        {
            bool found = false;
            int row = 0;
            foreach(Location l in Data.locations)
            {         
                if(this.drpLocation.SelectedItem.ToString() == l.getLocationName())
                {
                    Year[] years = l.getYearlyObsv();
                    if (years != null)
                    {
                        foreach (Year y in years)
                        {
                            if (this.txtYear.Text == y.GetYear().ToString())
                            {
                                MonthlyObsv[] months = y.GetMonthlyObsv();
                                foreach (MonthlyObsv m in months)
                                {
                                    found = true;

                                    this.dgvMonthlyObsv[1, row].Value = m.GetMaxTemp();
                                    this.dgvMonthlyObsv[2, row].Value = m.GetMinTemp();
                                    this.dgvMonthlyObsv[3, row].Value = m.GetNumDaysAirFrost();
                                    this.dgvMonthlyObsv[4, row].Value = m.GetAmountOfRain();
                                    this.dgvMonthlyObsv[5, row].Value = m.GetHrsOfSun();
                                    row++;
                                }
                            }
                        }
                    }
                }
            }
            if(found != true)
            {
                for (int r = 0; r < this.dgvMonthlyObsv.RowCount; r++)
                {
                    for (int c = 1; c < 6; c++)
                    {
                        this.dgvMonthlyObsv[c, r].Value = "NO DATA";
                    }
                }
                MessageBox.Show("No Data Found For " + this.txtYear.Text + " In " + this.drpLocation.SelectedItem,"Attention",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                dataAdded = false;
            }
            else
            {
                dataAdded = true;
            }
        }

        public void updateArray()
        {
            int row = 0;
            foreach (Location l in Data.locations)
            {
                if (this.drpLocation.SelectedItem.ToString() == l.getLocationName())
                {
                    Year[] years = l.getYearlyObsv();
                    foreach (Year y in years)
                    {
                        if (this.txtYear.Text == y.GetYear().ToString())
                        {
                            MonthlyObsv[] months = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in months)
                            {
                                m.SetMaxTemp(this.dgvMonthlyObsv[1, row].Value.ToString());
                                m.SetMinTemp(this.dgvMonthlyObsv[2, row].Value.ToString());
                                m.SetNumDaysAirFrost(this.dgvMonthlyObsv[3, row].Value.ToString());
                                m.SetAmountOfRain(this.dgvMonthlyObsv[4, row].Value.ToString());
                                m.SetHrsOfSun(this.dgvMonthlyObsv[5, row].Value.ToString());
                                row++;
                            }
                        }
                    }
                }
            }       
            saveFile();
        }

        public void saveFile()
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
                MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You Must Select a File to Update or Enter A New FileName", "Warning", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            
        }

        private void frmEditMonth_Load(object sender, EventArgs e)
        {
            addRows();
            addLocation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMonth tempMonth = new frmMonth();
            tempMonth.Show();
            FrmEditMonth.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchYear();
        }

        private void drpLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataAdded == true)
            {
                DialogResult result = MessageBox.Show("Are You Sure You Wish To Make These Changes?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);


                if (result == DialogResult.Yes)
                {
                    updateArray();
                }
            }
            else
            {
                MessageBox.Show("You Need To Edit Some Data Before Saving", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
         
        }
    }
}
