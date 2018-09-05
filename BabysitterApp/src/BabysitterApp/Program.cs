using System;

namespace BabysitterApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            
            DateTime endTime;
            DateTime startTime;
            Babysitter b = new Babysitter();

            //Initial setup of some of the message we will send to the user to collect and display info
            Console.WriteLine("Welcome to the Babysitter Application!");
            Console.WriteLine("You will need to enter the following information to calculate your total cost:");


            //Prompt for Start Time
            Console.WriteLine("Please enter your start time and arrival date, for example (9/04/2018 9:00pm):");
            string strStartTime = Console.ReadLine();
            var isStartTimeValid = false;
            while (isStartTimeValid == false)
            {
                strStartTime = Console.ReadLine();

                if (DateTime.TryParse(strStartTime, out startTime))
                {
                    b.StartTime = startTime;

                    if (b.IsStartTimeValid())
                    {
                        isStartTimeValid = true;
                    }
                }

                if (isStartTimeValid == false)
                {
                    Console.WriteLine("Not a valid date/time, Please enter your start time and arrival date, for example (9/04/2018 9:00pm):");
                }

            }
            

            //Prompt for End Time
            Console.WriteLine("Please enter your end time and departure date, for example (9/05/2018 1:00am):");
            string strEndTime = Console.ReadLine();
            var isEndTimeValid = false;
            while (isEndTimeValid == false)
            {
                strEndTime = Console.ReadLine();

                if (DateTime.TryParse(strEndTime, out endTime))
                {
                    b.EndTime = endTime;

                    if (b.IsEndTimeValid() && b.IsTimesValid())
                    {
                        isEndTimeValid = true;
                    }
                }

                if (isEndTimeValid == false)
                {
                    Console.WriteLine("Not a valid date/time, Please enter your end time and departure date, for example (9/05/2018 1:00am):");
                }

            }
                        
            Console.WriteLine("This is the babysitter cost:" + b.CalculateCost());
            

        }
    }
}
