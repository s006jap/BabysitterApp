using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabysitterApp
{
    public class Babysitter
    {

        //Variables needed for both times and probably for bedTime and possibly storing midnight
        private DateTime startTime;
        private DateTime endTime;
        
        private DateTime bedTime;
        private DateTime midnight;

        double[] CostTime = { 12, 8, 16 };
        TimeSpan[] TotalTime = new TimeSpan[3];
        

        public double CalculateCost()
        {

            //Need to figure out how to split up the time, into the 3 groupings
            //how much time is between startTime and 9pm
            //how much time is between 9pm and midnight
            //how much time is between midnight and endTime

            //Assume babysitter always stays until bedtime, bedtime is 9pm for now
            bedTime = DateTime.Today.AddHours(21);
            midnight = DateTime.Today.AddHours(24);

            TotalTime[0] = this.bedTime - startTime;
                        

            //Beginning of logic to calculate these three values
            if (EndTime >= midnight)
            {
                TotalTime[2] = endTime - midnight;
                TotalTime[1] = midnight - bedTime;

            } else if (endTime < midnight)
            {
                TotalTime[1] = endTime - bedTime;
            }

            var c1 = (TotalTime[0].TotalHours * CostTime[0]);
            var c2 = (TotalTime[1].TotalHours * CostTime[1]);
            var c3 = (TotalTime[2].TotalHours * CostTime[2]);

            return c1 + c2 + c3;

        }


        public bool IsStartTimeValid()
        {
            //Is time entered after 5:00pm
            return true;
        }

        public bool IsEndTimeValid()
        {
            //Is time entered before 4:00am
            return true;
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
