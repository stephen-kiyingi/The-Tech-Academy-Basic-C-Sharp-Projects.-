using System;
using System.Collections.Generic;

namespace ConsoleApp_Array_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array of strings
            string[] nameArray = { "Raymond", "Dechus", "Stephen" };
            //ask the user for a number to display the string at that index
            Console.WriteLine("Select a number between 0 and 2:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("whats your fathers name " + nameArray[stringSelect]);
                    validString = true;

                }
                //add a message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("sorry, that number selection is invalid.Please select a number between 0 and 2. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());

                }
            }

        //list of strings
        List<string>SubjectList = new List<string>()
        {
             "Maths",
             "English",
             "Economics",
        };

        //ask the user for a number to display the string at that index
        Console.WriteLine("\nSelect another number between 0 and 2:");
        int listSelect = Convert.ToInt32(Console.ReadLine());
        bool validList = false;

        while (!validList)
        {
            try
            {
                Console.WriteLine("Your favorite subject is: " + SubjectList[listSelect]);
                validList = true;
            }
            //add a message to display if the user picks an index that doesnt exist
            catch
            {
               Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 2. ");
               listSelect = Convert.ToInt32(Console.ReadLine());
    

        
       

    }
}
            //array of integers
            int[] intArray = { 17, 22, 3, 67, 5, 91, 11, 42, 23, 6 };
            //ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect a third number between 0 and 9:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                //add a meassage to display if the user picks a wrong index
                catch
                {
                    Console.WriteLine("sorry, that number selected is invalid, select a number between 0 and 9.");
                }
            }
