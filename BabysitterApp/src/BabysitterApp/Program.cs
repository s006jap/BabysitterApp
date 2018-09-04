using System;

namespace BabysitterApp
{
    public class Program
    {
        public void Main(string[] args)
        {

            DateTime startTime;
            DateTime endTime;
           
            //Initial setup of some of the message we will send to the user to collect and display info
            Console.WriteLine("Welcome to the Babysitter Application!");
            Console.WriteLine("You will need to enter the following information to calculate your total cost:");
                     
            
            Console.WriteLine("Please enter your start time and arrival date, for example (9/04/2018 9:00pm):");
            string strStartTime = Console.ReadLine();
            if (DateTime.TryParse(strStartTime, out startTime))
            {

            }
           
            Console.WriteLine("Please enter your end time and departure date, for example (9/05/2018 1:00am):");
            string strEndTime = Console.ReadLine();
            if (DateTime.TryParse(strEndTime, out endTime))
            {

            }


            Babysitter b = new Babysitter();
            b.StartTime = startTime;
            b.EndTime = endTime;

            Console.WriteLine("This is your cost:" + b.CalculateCost());
            

        }
    }
}
