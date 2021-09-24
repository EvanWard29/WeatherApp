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
    public partial class frmYearData : Form
    {
        public static frmYearData tempYearData = null;
        public frmYearData()
        {
            InitializeComponent();
            tempYearData = this;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmYearlyObsv tempYearlyObsv = new frmYearlyObsv();
            tempYearlyObsv.Show();
            tempYearData.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool search = true;
            if (checkInput() != true)
            {
                loadTabs(search);     
            }   
        }

        //Validate input
        public bool checkInput()
        {
            bool error = false;
            int searchYear = 0;

            try
            {
                searchYear = Convert.ToInt32(this.txtSelectYear.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter Valid Data Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            return error;
        }

        private void frmYearData_Load(object sender, EventArgs e)
        {
            loadTabs(false);
        }

        //Create new tab for each location in array
        public void loadTabs(bool search)
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

            int numTabs = this.tabYears.TabPages.Count;
            if (numTabs != 1)
            {
                foreach (string i in locations)
                {
                    this.tabYears.TabPages.RemoveByKey(i);
                }
                setTabs(search);
            }
            else
            {
                setTabs(search);
            }
        }

        //For each tab, create a new DataGridView
        public void setTabs(bool search)
        {
            
            foreach (Location l in Data.locations)
            {
                Year[] years = l.getYearlyObsv();

                TabPage newTab = new TabPage();
                newTab.Name = l.getLocationName();
                newTab.Text = l.getLocationName();

                DataGridView grid = createGrid(l.getLocationName());
                setRows(grid);
                if (search == true)
                {
                    searchData(grid);
                }                            
                newTab.Controls.Add(grid);
                this.tabYears.Controls.Add(newTab);
            }   
        }

        //Create Data Grid
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
            grid.Columns[0].Name = "Month ID";
            grid.Columns[1].Name = "Maximum Temperature";
            grid.Columns[2].Name = "Minimum Temperature";
            grid.Columns[3].Name = "Number of Frosty Days";
            grid.Columns[4].Name = "Milimetres of Rain";
            grid.Columns[5].Name = "Hours of Sun";  

            return grid;
        }

        //Set number of rows, default value is "NO DATA"
        public void setRows(DataGridView grid)
        {
            grid.RowCount = 12;

            for (int i = 0; i < 12; i++)
            {
                grid[0, i].Value = i + 1;
                for (int j = 1; j < 6; j++)
                {
                    grid[j, i].Value = "NO DATA";
                }
            }
        }

        
        public void searchData(DataGridView grid)
        {
            int row = 0;
            foreach (Location l in Data.locations)
            {
                if (grid.Name == "dgvLocation" + l.getLocationName().ToUpper())
                {
                    Year[] years = l.getYearlyObsv();
                    if (years == null)
                    {
                        //MessageBox.Show("There Is No Data For " + l.getLocationName() + "\nYou Need to Add At Least 1 Set Of Data",
                            //"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //For each year in location show data in grid
                        foreach (Year y in years)
                        {
                            MonthlyObsv[] months = y.GetMonthlyObsv();
                            foreach (MonthlyObsv m in months)
                            {
                                if (y.GetYear() == Convert.ToInt32(this.txtSelectYear.Text))
                                {
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
                }
            }
        }
    }
       
}
