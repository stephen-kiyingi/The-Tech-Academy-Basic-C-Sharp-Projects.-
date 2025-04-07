using System;

namespace SHIP_IT_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express");
            Console.WriteLine("What is the weight of the Package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)//check if the weight is greater than 50
            {
                Console.WriteLine("Package is too heavy,display an error message and end the program");
                return;//exit the program
            }

            //prompt the user for the package width
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            //prompt the user for package height
            Console.WriteLine("Please enter the package height");
            double height = Convert.ToDouble(Console.ReadLine());

            //prompt the user for the package length
            Console.WriteLine("please enter the package length");
            double length = Convert.ToDouble(Console.ReadLine());

            //check if the total dimension(width + height + length) exceed 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via package Express");
                return;//exit the program
            }
            //Calculate the shipping quote:
            //multiply the three dimensions together (width*height*length),then multiply by the weight.
            //then divide the result by 100 to get the final quote.
            double quote = ((width * height * length) * weight) / 100;

            //display the estimated shipping cost as dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:f2}");

            }
        }
    }
