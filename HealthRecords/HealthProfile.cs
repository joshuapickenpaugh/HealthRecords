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

        private bool _IsMale = false;
        public bool IsMale
        {
            get { return _IsMale; }
            set { _IsMale = value; }
        }

        private bool _IsFemale = false;
        public bool IsFemale
        {
            get { return _IsFemale; }
            set { _IsFemale = value; }
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


        private double _InchesHeight;
        public double InchesHeight
        {
            get { return _InchesHeight; }
            set { _InchesHeight = value; }
        }

        private double _LBS;
        public double LBS
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

            strAge = "Age is: " + Convert.ToString(intAge);

            return strAge;
        }

        //Gets BMI:
        public string GetBMI()
        {
            const double BMI_NUMBER = 703;
            double dblBMI = 0;
            string strBMI;

            dblBMI = BMI_NUMBER * (LBS / InchesHeight / InchesHeight);
            dblBMI = Math.Round(dblBMI, 1);

            //Returns BMI with weight message:
            if (dblBMI < 18.5)
            {
                strBMI = "BMI is: " + Convert.ToString(dblBMI) + ". UNDERWEIGHT.";
                return strBMI;
            }
            if (dblBMI >= 18.5 && dblBMI <= 24.9)
            {
                strBMI = "BMI is: " + Convert.ToString(dblBMI) + ". HEALTHY WEIGHT.";
                return strBMI;
            }
            if (dblBMI >= 25 && dblBMI <= 29.9)
            {
                strBMI = "BMI is: " + Convert.ToString(dblBMI) + ". OVERWEIGHT.";
                return strBMI;
            }
            else
            {
                strBMI = "BMI is: " + Convert.ToString(dblBMI) + ". OBESE.";
                return strBMI;
            }
        }
    }
}
