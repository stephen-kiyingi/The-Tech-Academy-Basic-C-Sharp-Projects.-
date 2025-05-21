
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print the current date and time to the console 
            DateTime currentTime = DateTime.Now;//get the current system date and time.
            Console.WriteLine("Current date and time: " + currentTime);

            //Ask the user for the number (number of hours to add)
            Console.WriteLine("Enter a number of hours to add: ");
            string input = Console.ReadLine();//Read user input  from the console

            //Convert the input string to an integer
            int hoursToAdd = int.Parse(input);

            //calculate the future  time by adding a given  number of hours
            DateTime futureTime = currentTime.AddHours(hoursToAdd);//add hours to the current time 

            //print the result to the console 
            Console.WriteLine($" in {hoursToAdd} hour(s), the date and time will be: {futureTime}");

            

        }
    }
}
