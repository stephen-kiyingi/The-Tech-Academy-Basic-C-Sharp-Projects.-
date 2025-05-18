using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeFilterApp
{
    //define an employee class with id, FirstName, and LastName properties
    public class Employee
    {
        public int Id { get; set; }// employee ID
        public string FirstName { get; set; } // employee first name
        public string LastName { get; set; }// employee LastNmae
    }
    class program
    {
        static void Main(string[] args)
        {
            //create and initialize a list of 10 employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "John", LastName = "Williams" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Black" },
                new Employee { Id = 5, FirstName = "Alice", LastName = "Johnson" },
                new Employee { Id = 6, FirstName = "Bob", LastName = "Davis" },
                new Employee { Id = 7, FirstName = "Charlie", LastName = "Brown" },
                new Employee { Id = 8, FirstName = "Dana", LastName = "White" },
                new Employee { Id = 9, FirstName = "Eva", LastName = "Green" },
                new Employee { Id = 10, FirstName = "Frank", LastName = "Miller" }
            };

            // create a list top hold employees with the first name "joe" using foreach
            List<Employee> joesForeach = new List<Employee>();

            //loop through each employee and check if their FirstName is "joe"
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joesForeach.Add(emp);// Add to list if condition is met
                }
            }
            // output the result from the foreach method
            Console.WriteLine("Employees named Joe (using foreach):");
            foreach (var joe in joesForeach)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} (Id: {joe.Id}");
            }
            //use a lambda expression to filter employee named "Joe"
            List<Employee> joesLambda = employees.Where(emp => emp.FirstName == "Joe").ToList();

            //output the results from the lambda expression
            Console.WriteLine("\nEmployees named Joe (using lambda):");
            foreach (var joe in joesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} Id: {joe.Id})");

            }
            //use a lambda expression to filter employeeswith Id > 5
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.Id > 5).ToList();

            //output the results
            Console.WriteLine("\nEmployee with Id greater than 5:");
            foreach (var emp in idGreaterThanFive)
            {
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }

    }
}

                
 

