using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT152_Coursework2018
{
    class Year
    {
        private int year;
        private string comment;
        private MonthlyObsv[] monthlyObsv;

        public Year(string Year, string Comment, MonthlyObsv[] MonthlyObservation)
        {
            SetYear(Year);
            comment = Comment;
            monthlyObsv = MonthlyObservation;
        }

        public Year(string Year, string Comment)
        {
            SetYear(Year);
            comment = Comment;
            monthlyObsv = null;
        }

        public void SetYear(string Year)
        {
            try
            {
                year = Convert.ToInt32(Year);
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Data Type Used For Year ID", "Error");
            }
        }
        public void SetComment(string Comment)
        {
            comment = Comment;
        }
        public void SetMonthlyObsv(MonthlyObsv[] MonthlyObservation)
        {
            monthlyObsv = MonthlyObservation;
        }

        public int GetYear()
        {
            return year;
        }
        public string GetComment()
        {
            return comment;
        }
        public MonthlyObsv[] GetMonthlyObsv()
        {
            return monthlyObsv;
        }
    }
}
