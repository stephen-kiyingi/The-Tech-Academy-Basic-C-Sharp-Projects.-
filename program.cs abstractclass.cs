using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //in the main method, instatiate an Employee object
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call the SayNmae method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
