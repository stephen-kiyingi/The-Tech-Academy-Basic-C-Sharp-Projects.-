using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class_Assignment
{
    public class Employee : Person
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of the employee class
        public override void SayName()
        {
            Console.WriteLine("Name:" + FirstName + " " + LastName); 
        }
    }
}
