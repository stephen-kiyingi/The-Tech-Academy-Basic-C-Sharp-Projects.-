
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Constructor_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a const vsriable
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is: ";
            Console.WriteLine("Enter your name or favorite number:");
            //Create a varaible using the var keyword
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine(const1);
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}
