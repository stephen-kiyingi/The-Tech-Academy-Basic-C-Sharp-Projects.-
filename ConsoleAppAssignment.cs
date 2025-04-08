using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while loop
            int count = 0;
            do
            {
                Console.WriteLine("inside the loop");
                count++;// add one each time
            }
            while (count < 5);//continue to loop untill 5

            //while loop
            int counting = 0;
            while (counting < 3)//continue to loop til reaches 3
            {
                Console.WriteLine("counting  numbers");
                count++; //add one each time
            }
            Console.ReadLine();
        }
    }
}
