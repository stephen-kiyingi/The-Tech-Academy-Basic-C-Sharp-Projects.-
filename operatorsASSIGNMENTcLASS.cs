using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    //define the employee class with Id, FirstName and LastName properties

    public class Employee
    {
        //unique identifier for each employee
        public int Id { get; set; }

        //FirstName of the Employee
        public string FirstName { get; set; }
        //LastNmae of the Employee

        public string LastName { get; set; }
        //overload the "==" operator to compare Employee by their id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //if both objects are null, return true
            if (ReferenceEquals(emp1, emp2)) return true;

            //if either objects is null ,return false
            if (emp1 is null || emp2 is null)
                return false;

            //compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }
        //overload the "!=" opeartor (must be paired with "==")
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
        //override equals() for consistency with overloaded "=="
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id;
            }

            return false;
        }
        //overide GetHashCode() when Equals is overridden
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}