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
    public partial class frmMain : Form
    {
        public static frmMain frmMainMenu = null;

        public frmMain()
        {
            InitializeComponent();
            frmMainMenu = this;
        }

        private void setUpLocation(StreamReader file)
        {   
            int numOfLocations, numOfYears, arraySize;
            string LocationName, StreetNumName, County, Postcode, Latitude, Longitude;
            
            //Gets number of locations in file
            numOfLocations = Convert.ToInt32(file.ReadLine());

            //Reads till end of file
            while (!file.EndOfStream)
            {
                LocationName = file.ReadLine();
                StreetNumName = file.ReadLine();
                County = file.ReadLine();
                Postcode = file.ReadLine();
                Latitude = file.ReadLine();
                Longitude = file.ReadLine();

                //Gets number of years stored in that Location
                numOfYears = Convert.ToInt32(file.ReadLine());

                //Creates new Location object using data read from file
                Location tempLocation = new Location(LocationName, StreetNumName, County, Postcode, Latitude.ToString(), Longitude.ToString());

                //Gets Yearly Observations
                tempLocation.setYearlyObsv(setUpYear(file, numOfYears, tempLocation.getYearlyObsv()));

                if (Data.locations == null)
                {
                    arraySize = 0;
                }
                else
                {
                    arraySize = Data.locations.Length;
                }

                //Resizes locations array
                Array.Resize(ref Data.locations, arraySize + 1);

                //Adds new Location object to array
                Data.locations[arraySize] = tempLocation;
            }
            file.Close();
        }

        private Year[] setUpYear(StreamReader file, int NumOfYears, Year[] year)
        {
            string yearDescription, YearID;
            int arraySize;

            //Read through filebased on number of years in that Location
            for (int i = 0; i < NumOfYears; i++)
            {
                yearDescription = file.ReadLine();
                YearID = file.ReadLine();

                //Creates new Year object
                Year tempYear = new Year(YearID, yearDescription);

                //Gets Monthly Observations for that year
                tempYear.SetMonthlyObsv(setUpMonths(file, tempYear.GetMonthlyObsv()));

                if (year == null)
                {
                    arraySize = 0;
                }
                else
                {
                    arraySize = year.Length;
                }

                //Resizes year array
                Array.Resize(ref year, arraySize + 1);

                //Adds Year object to year array
                year[arraySize] = tempYear;
            }

            //Returns year array and stores in locations array
            return year;
        }

        private MonthlyObsv[] setUpMonths(StreamReader file, MonthlyObsv[] month)
        {
            string MonthID, NumDaysFrost, MaxTemp, MinTemp, AmountOfRain, HrsSun;
            int YearID;
            int arraySize;

            //Read file for 12 months
            for (int i = 0; i < 12; i++)
            {
                MonthID = file.ReadLine();
                MaxTemp = file.ReadLine();
                MinTemp = file.ReadLine();
                NumDaysFrost = file.ReadLine();
                AmountOfRain = file.ReadLine();
                HrsSun = file.ReadLine();
                
                //If the monthID is 12, don't read the YearID
                if (i != 11)
                {
                    YearID = Convert.ToInt32(file.ReadLine());
                }

                //Creates a new Monthly Observation object
                MonthlyObsv tempMonth = new MonthlyObsv(MonthID, MaxTemp, MinTemp, NumDaysFrost,
                    AmountOfRain, HrsSun);

                if (month == null)
                {
                    arraySize = 0;
                }
                else
                {
                    arraySize = month.Length;
                }

                //Resizes month array
                Array.Resize(ref month, arraySize + 1);

                //Stores Monthly Observation object in month array
                month[arraySize] = tempMonth;
            }

            //Returns month array to store in year array
            return month;
        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
            //When form loads
            //Checks to see if data has already been read from file
            if (Data.locations == null)
            {   
                while (true)
                {
                    //User selects file
                    fileSelect.ShowDialog();
                    string fileName = fileSelect.FileName;

                    try
                    {
                        //Open selected file for reading
                        StreamReader file = new StreamReader(fileName);
                        setUpLocation(file);
                        break;
                    }
                    catch (FileNotFoundException NotFound)
                    {
                        //File does not exist
                        MessageBox.Show(NotFound.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                    }
                }              
            }
        }

        private void btnSelectMnth_Click(object sender, EventArgs e)
        {
            //Opens Monthly Observations form
            frmMonth tempMonth = new frmMonth();
            tempMonth.Show();
            frmMainMenu.Hide();
        }    

        private void btnSelectYr_Click(object sender, EventArgs e)
        {
            //Opens Yearly Observations form
            frmYearlyObsv tempYearlyObsv = new frmYearlyObsv();
            tempYearlyObsv.Show();
            frmMainMenu.Hide();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            //Opens Location form
            frmLocation tempLoc = new frmLocation();
            tempLoc.Show();
            frmMainMenu.Hide();
        }
    }
}
