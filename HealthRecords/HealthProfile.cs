using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecords
{
    class HealthProfile
    {
        //Vars with Get/Set:
        private string _FName;
        public string FName
        {
            get { return _FName; }
            set { _FName = value; }
        }

        private string _LName;
        public string LName
        {
            get { return _LName; }
            set { _LName = value; }
        }

        private char _Gender;
        public char Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        private int _Month;
        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        private int _Day;
        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        private int _Year;

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        private int _DobDayOfYear;

        public int DobDayOfYear
        {
            get { return _DobDayOfYear; }
            set { _DobDayOfYear = value; }
        }


        private int _InchesHeight;
        public int InchesHeight
        {
            get { return _InchesHeight; }
            set { _InchesHeight = value; }
        }

        private int _LBS;
        public int LBS
        {
            get { return _LBS; }
            set { _LBS = value; }
        }

        //Gets age:
        public string GetAge()
        {
            int intAge = 0;
            string strAge;

            intAge = DateTime.Now.Year - Year;
            if (DateTime.Now.DayOfYear < DobDayOfYear)
            {
                intAge = intAge - 1;
            }            

            strAge = Convert.ToString(intAge);

            return strAge;
        }





    }
}
