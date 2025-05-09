using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        //create a list of integers
        List<int>intList = new List<int>() { 2, 8, 10, 12, 14 };
        //ask theuser for input and loop through the list diving each number by the input
        bool numValid = false;
        while (!numValid)
        {
            //using a try /catch block to give error message
            try
            {
                Console.WriteLine("\nenter a number to divide the above list by:");
                float numDivide = float.Parse(Console.ReadLine());
                //if statement to check if the user entered 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                //Divide each number in the above list by the input
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }

            }
            //catch a block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("invalid input.Please enter a number.");
            }
        }
        //message to let the user know the program has existed the try/catch block
        Console.WriteLine("Program has exited the try/catch block");
    }
}

