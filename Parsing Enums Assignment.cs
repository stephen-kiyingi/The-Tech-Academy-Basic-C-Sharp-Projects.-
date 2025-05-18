using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
     class Program
    {
        //Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
                bool  isvalid = false;
                while(!isvalid) 
                {
                    try
                    {
                        //prompt the user to enter the current day of the week.
                        Console.WriteLine("Enter the current day of the week");
                        string dayinput = Console.ReadLine();
                        //assign the value to a variable of that enum data type ypu just created.
                        DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                        Console.WriteLine("Have a nice" + day);
                        Console.ReadLine();
                        isvalid = true;
                    }
                    catch {
                        Console.WriteLine("Please enter an actual day of the week");
                    
                    }
            }
        }
    }
}
