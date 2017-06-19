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

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
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

        private double _MaxHeartRate;
        public double MaxHeartRate
        {
            get { return _MaxHeartRate;; }
            set { _MaxHeartRate = value; }
        }

        private double _HighTargetHeartRate;
        public double HighTargetHeartRate
        {
            get { return _HighTargetHeartRate;; }
            set { _HighTargetHeartRate = value; }
        }

        private double _LowTargetHeartRate;
        public double LowTargetHeartRate
        {
            get { return _LowTargetHeartRate; }
            set { _LowTargetHeartRate = value; }
        }

        //Gets age:
        public string GetAge()
        {
            string str;

            Age = DateTime.Now.Year - Year;
            if (DateTime.Now.DayOfYear < DobDayOfYear)
            {
                Age = Age - 1;
            }

            return str = "Age is: " + Convert.ToString(Age); 
        }

        //Gets BMI:
        public string GetBMI()
        {
            const double BMI_NUMBER = 703;
            double dblBMI = 0;
            string str;

            dblBMI = BMI_NUMBER * (LBS / InchesHeight / InchesHeight);
            dblBMI = Math.Round(dblBMI, 1, MidpointRounding.AwayFromZero);

            //Returns BMI with weight message:
            if (dblBMI < 18.5)
            {
                return str = "BMI is: " + Convert.ToString(dblBMI) + ". UNDERWEIGHT."; 
            }
            if (dblBMI >= 18.5 && dblBMI <= 24.9)
            {
                return str = "BMI is: " + Convert.ToString(dblBMI) + ". HEALTHY WEIGHT."; 
            }
            if (dblBMI >= 25 && dblBMI <= 29.9)
            {
                return str = "BMI is: " + Convert.ToString(dblBMI) + ". OVERWEIGHT."; 
            }
            else
            {
                return str = "BMI is: " + Convert.ToString(dblBMI) + ". OBESE."; 
            }
        }

        //Gets Max Heart Rate:
        public string GetMaxHeartRate()
        {
            const double MAX_HEART_RATE_VALUE = 220;
            string str = "";

            MaxHeartRate = MAX_HEART_RATE_VALUE - Age;

            return str = "Max heart rate is: " + Convert.ToString(MaxHeartRate) + ".";
        }

        //Gets Target Heart Rate range:
        public string GetTargetHeartRateRange()
        {
            const double HIGH_TARGET = .85;
            const double LOW_TARGET = .5;
            string str;

            HighTargetHeartRate = MaxHeartRate * HIGH_TARGET;
            LowTargetHeartRate = MaxHeartRate * LOW_TARGET;

            return str = "High target HR: " + Convert.ToString(HighTargetHeartRate) + 
                ". Low target HR: " + Convert.ToString(LowTargetHeartRate) + ".";              
        }
    }
}
