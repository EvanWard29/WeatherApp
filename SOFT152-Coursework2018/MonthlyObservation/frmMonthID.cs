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
    public partial class frmMonthID : Form
    {
        public static frmMonthID frmMonthIDData = null;
        public frmMonthID()
        {
            InitializeComponent();
            frmMonthIDData = this;
        }

        public void setUpOptions()
        {
            string[] month = new string[12] {"January","February","March","April","May","June","July","August",
                "September","October","November","December"};

            for (int i = 0; i < 12; i++)
            {
                int monthID = i + 1;
                this.drpMonthID.Items.Add(month[i] + "(" + monthID + ")");
            }
            this.drpMonthID.SelectedIndex = 0;            
        }

        public void getTabs()
        {
            string[] locations = new string[0];

            int arraySize;
            foreach (Location L in Data.locations)
            {
                if (locations == null)
                {
                    arraySize = 0;
                }
                else
                {
                    arraySize = locations.Length;
                }
                Array.Resize(ref locations, arraySize + 1);
                locations[arraySize] = L.getLocationName();
            }

            int numTabs = this.tabLocation.TabPages.Count;
            if (numTabs != 1)
            {
                foreach (string i in locations)
                {
                    this.tabLocation.TabPages.RemoveByKey(i);
                }
                setTabs();
            }
            else
            {
                setTabs();
            }
        }

        public void setTabs()
        {
            foreach (Location l in Data.locations)
            {
                Year[] years = l.getYearlyObsv();

                TabPage newTab = new TabPage();
                newTab.Name = l.getLocationName();
                newTab.Text = l.getLocationName();

                DataGridView grid = createGrid(l.getLocationName());
                SetRows(grid);
                newTab.Controls.Add(grid);
                this.tabLocation.Controls.Add(newTab);          
            }        
        }  

        private DataGridView createGrid(string LocationName)
        {
            int MonthID = 0;
            DataGridView grid = new DataGridView();
            grid.Name = "dgvLocation" + LocationName.ToUpper();
            MonthID++;
            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Font = new Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.ColumnCount = 6;
            grid.Columns[0].Name = "Year";
            grid.Columns[1].Name = "Maximum Temperature";
            grid.Columns[2].Name = "Minimum Temperature";
            grid.Columns[3].Name = "Number of Frosty Days";
            grid.Columns[4].Name = "Milimetres of Rain";
            grid.Columns[5].Name = "Hours of Sun";

            return grid;
        }

        private void SetRows(DataGridView grid)
        {
            int rowCount = 0;  
            foreach (Location l in Data.locations)
            {
                if (grid.Name == "dgvLocation" + l.getLocationName().ToUpper())
                {
                    Year[] year = l.getYearlyObsv();
                    if (year != null)
                    {
                        foreach (Year y in year)
                        {
                            MonthlyObsv[] month = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in month)
                            {
                                if (m.GetMonthID() == this.drpMonthID.SelectedIndex + 1)
                                {
                                    rowCount++;
                                    grid.RowCount = rowCount + 1;
                                }
                            }
                        }
                    }
                    
                }
            }
            addData(grid);
        }

        private void addData(DataGridView grid)
        {
            int row = 0;
            foreach (Location l in Data.locations)
            {
                if (grid.Name == "dgvLocation" + l.getLocationName().ToUpper())
                {
                    Year[] years = l.getYearlyObsv();
                    if (years != null)
                    {
                        foreach (Year y in years)
                        {
                            MonthlyObsv[] months = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in months)
                            {
                                if (m.GetMonthID() == this.drpMonthID.SelectedIndex + 1)
                                {
                                    grid[0, row].Value = y.GetYear();
                                    grid[1, row].Value = m.GetMaxTemp() + "°C";
                                    grid[2, row].Value = m.GetMinTemp() + "°C";
                                    grid[3, row].Value = m.GetNumDaysAirFrost();
                                    grid[4, row].Value = m.GetAmountOfRain() + "mm";
                                    grid[5, row].Value = m.GetHrsOfSun();

                                    row++;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            grid[i, row].Value = "NO DATA";
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMonth tempMonth = new frmMonth();
            tempMonth.Show();
            frmMonthIDData.Close();
        }

        private void frmMonthID_Load(object sender, EventArgs e)
        {
            setUpOptions();     
        }

        private void drpMonthID_SelectedIndexChanged(object sender, EventArgs e)
        { 
            getTabs();      
        }
    }
}
