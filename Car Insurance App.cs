﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_App
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance App");
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower ();
            bool dui = answer == "yes";
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine("qualified");
        }
    }
}
