using System;
using System.Dynamic;

namespace Operators_Assignment
{
    class propgram
    {
        static void Main(string[] args)
        {
            //create the first employee object and assign values
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Johnson"
            };
            //create the second employee object and assign values
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Smith"
            };
            //compare the two employees using the overloaded "=="
            bool areEqual = employee1 == employee2;

            //display the comparison result
            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

            //compare the employees with the same ID
            employee2.Id = 101; //now both employees have the same Id

            //re-evaluate equality after updating employee2's id
            areEqual = employee1 == employee2;

            //Display updated comparison result
            Console.WriteLine("after updating employee2's Id:");
            Console.WriteLine("Are employee1 and employee2 equal?" + areEqual);
        }
    }
}