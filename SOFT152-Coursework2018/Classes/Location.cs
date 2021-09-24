using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Coursework2018
{
    class Location
    {
        private string locationName;
        private string streetNumName;
        private string county;
        private string postcode;
        private double latitude;
        private double longitude;
        private Year[] yearlyObsv;

        public Location(string LocationName, string StreetNumName, string StreetName, string County, string Postcode, string Latitude,
            string Longitude, Year[] YearlyObsv)
        {
            locationName = LocationName;
            streetNumName = StreetNumName;
            county = County;
            postcode = Postcode;
            setLatitude(Latitude);
            setLongitude(Longitude);
            yearlyObsv = YearlyObsv;
        }
        public Location(string LocationName, string StreetNumName, string County, string Postcode, string Latitude,
            string Longitude)
        {
            locationName = LocationName;
            streetNumName = StreetNumName;
            county = County;
            postcode = Postcode;
            setLatitude(Latitude);
            setLongitude(Longitude);
            yearlyObsv = null;
        }

        public void setLocationName(string LocationName)
        {
            locationName = LocationName;
        }
        public void setStreetNumName(string StreetNumName)
        {
            streetNumName = StreetNumName;
        }
        public void setCounty(string County)
        {
            county = County;
        }
        public void setPostcode(string Postcode)
        {
            postcode = Postcode;
        }
        public void setLatitude(string Latitude)
        {
            try
            {
                latitude = Convert.ToDouble(Latitude);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Latitude", "Error");
            }
        }
        public void setLongitude(string Longitude)
        {
            try
            {
                longitude = Convert.ToDouble(Longitude);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Longitude", "Error");
            }
        }
        public void setYearlyObsv(Year[] YearlyObsv)
        {
            yearlyObsv = YearlyObsv;
        }

        public string getLocationName()
        {
            return locationName;
        }
        public string getStreetNumName()
        {
            return streetNumName;
        }
        public string getCounty()
        {
            return county;
        }
        public string getPostcode()
        {
            return postcode;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongitude()
        {
            return longitude;
        }
        public Year[] getYearlyObsv()
        {
            return yearlyObsv;
        }
    }
}
