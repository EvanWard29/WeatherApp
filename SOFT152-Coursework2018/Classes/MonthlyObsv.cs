using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Coursework2018
{
    class MonthlyObsv
    {
        private int MonthID;
        private double MaxTemp;
        private double MinTemp;
        private int NumDaysAirFrost;
        private double mmOfRain;
        private double hrsOfSun;

        public MonthlyObsv(string monthID, string maxTemp, string minTemp, string NumDaysFrost, string mm_Of_Rain, string hrs_Of_Sun)
        {
            SetMonthID(monthID);
            SetMaxTemp(maxTemp);
            SetMinTemp(minTemp);
            SetNumDaysAirFrost(NumDaysFrost);
            SetAmountOfRain(mm_Of_Rain);
            SetHrsOfSun(hrs_Of_Sun);
        }

        public void SetMonthID(string monthID)
        {
            try
            {
                MonthID = Convert.ToInt32(monthID);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Month ID", "Error");
            }

        }
        public void SetMaxTemp(string maxTemp)
        {
            try
            {
                MaxTemp = Convert.ToDouble(maxTemp);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Max Temp", "Error");
            }

        }
        public void SetMinTemp(string minTemp)
        {
            try
            {
                MinTemp = Convert.ToDouble(minTemp);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Min Temp", "Error");
            }
        }
        public void SetNumDaysAirFrost(string NumDaysFrost)
        {
            try
            {
                NumDaysAirFrost = Convert.ToInt32(NumDaysFrost);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Number of Frosty Days", "Error");
            }
        }
        public void SetAmountOfRain(string mm_Of_Rain)
        {
            try
            {
                mmOfRain = Convert.ToDouble(mm_Of_Rain);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Millimetres Of Rain", "Error");
            }
        }
        public void SetHrsOfSun(string hrs_Of_Sun)
        {
            try
            {
                hrsOfSun = Convert.ToDouble(hrs_Of_Sun);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Hours Of Sun", "Error");
            }
        }

        public int GetMonthID()
        {
            return MonthID;
        }
        public double GetMaxTemp()
        {
            return MaxTemp;
        }
        public double GetMinTemp()
        {
            return MinTemp;
        }
        public int GetNumDaysAirFrost()
        {
            return NumDaysAirFrost;
        }
        public double GetAmountOfRain()
        {
            return mmOfRain;
        }
        public double GetHrsOfSun()
        {
            return hrsOfSun;
        }
    }
}
