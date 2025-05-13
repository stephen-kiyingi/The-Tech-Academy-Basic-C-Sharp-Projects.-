using System;
using System.Runtime.CompilerServices;
namespace ClassMethodAssignment
{
    class program
    {
        static void Main(string[] args)
        {
            //in the main() method instatiate the class
            VoidMethod math = new VoidMethod();
            //call the void method
            Console.WriteLine("input a number:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            math.MathOp(dividend);
            Console.WriteLine(math.Value);
            Console.ReadLine();
            //call the method with output parameters
            Console.WriteLine("input a phrase:");
            string input  = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            Console.ReadLine();
            //call the overloaded method
            Console.WriteLine("input another phrase:");
            string input2 = Console.ReadLine();
            int phrase2_len = math.StringCounter(input2);
            Console.WriteLine( "This phrase is " + phrase2_len + " characters long");
            Console.ReadLine();
            //CALL THE METHOD OF STATIC CLASS
            Console.WriteLine("input another phrase:");
            string input3 = Console.ReadLine(); 
            int i_count = VoidMethod.IFinder(input3);
            Console.WriteLine("This phrase has " + i_count + " i 's in it.");
            Console.ReadLine();

        }
    }
}
