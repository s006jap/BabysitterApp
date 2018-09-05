using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BabysitterApp
{
    public class Babysitter
    {
        //Assumptions:
        //1. Babysitter always stays until bedtime
        //2. Bedtime is 9pm

        //Variables needed for both times and probably for bedTime and possibly storing midnight
        private DateTime startTime;
        private DateTime endTime;
        
        private DateTime bedTime;
        private DateTime midnight;

        double[] CostTime = { 12, 8, 16 };
        TimeSpan[] TotalTime = new TimeSpan[3];
        

        public double CalculateCost()
        {
            //Move this to a config file
            bedTime = DateTime.Today.AddHours(21);
            midnight = DateTime.Today.AddHours(24);

            //how much time is between startTime and 9pm
            TotalTime[0] = bedTime - startTime;
            
            
            if (EndTime >= midnight)
            {
                //how much time is between midnight and endTime
                TotalTime[2] = endTime - midnight;

                //how much time is between 9pm and midnight
                TotalTime[1] = midnight - bedTime;

            } else if (endTime < midnight)
            {
                //babysitter ended before midnight, so no need to calculate third tier
                TotalTime[1] = endTime - bedTime;
            }
            
            var totalCost = 0.0;
            try
            {
                totalCost = (TotalTime[0].TotalHours * CostTime[0]) + (TotalTime[1].TotalHours * CostTime[1]) + (TotalTime[2].TotalHours * CostTime[2]);

            } catch (Exception e)
            {
               //Add in logging to write out error message
            }

            return totalCost;

        }


        public bool IsStartTimeValid()
        {
            //Is time entered after 5:00pm
            var rv = false;
            var comparisonDate = startTime;
            TimeSpan ts = new TimeSpan(17, 00, 0);
            comparisonDate = comparisonDate.Date + ts;

            if (startTime >= comparisonDate)
            {
                rv = true;
            }


            return rv;
        }

        public bool IsEndTimeValid()
        {
            //Is time entered before 4:00am
            var rv = false;
            var comparisonDate = endTime;
            TimeSpan ts = new TimeSpan(4, 00, 0);
            comparisonDate = comparisonDate.Date + ts;

            if (endTime <= comparisonDate)
            {
                rv = true;
            }

            return rv;
        }


        public bool IsTimesValid()
        {
            //Are both times valid
            return true;
        }


        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }


        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }



    }
}
