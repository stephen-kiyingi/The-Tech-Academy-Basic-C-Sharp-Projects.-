using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
     class Program
    {
        static void Main(string[] args)
        {
            //insiode of the main method , instatiate and initialize an employee objectwith the first name "sample" and the last name "stuident"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();

        }
    }
}

tem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    public class Person

    {
        //create a class called Person and give it two properties, each of data type string 
        //One called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called SayName() that takes no parameters and simply writes
        //the persons full name to the console in the format of : "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectAssignment
{
    //create another class called Employee and have it inherit from the person class
    public class Employee : Person

    {
        //give the Employee class a property called Id and have it be of data type int
        public int Id { get; set; }
    }
}

