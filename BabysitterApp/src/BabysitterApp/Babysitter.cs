using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabysitterApp
{
    public class Babysitter
    {

        //Variables needed for both times and probably for bedTime and possibly storing midnight
        DateTime startTime;
        DateTime endTime;
        DateTime bedTime;
        DateTime midnight;

        double[] CostTime = { 12, 8, 16 };
        TimeSpan[] TotalTime = new TimeSpan[3];
        

        public double CalculateCost()
        {

            //Need to figure out how to split up the time, into the 3 groupings
            //how much time is between startTime and 9pm
            //how much time is between 9pm and midnight
            //how much time is between midnight and endTime

            //Assume babysitter always stays until bedtime


            TotalTime[0] = this.bedTime - this.startTime;
                        

            //Beginning of logic to calculate these three values
            if (endTime >= midnight)
            {
                TotalTime[2] = endTime - midnight;
                TotalTime[1] = midnight - bedTime;

            } else if (endTime < midnight)
            {

            }
            
            return 0.0;

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

    }
}
