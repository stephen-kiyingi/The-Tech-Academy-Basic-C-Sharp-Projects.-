// File :Program.cs

using System;

class program
{
    static void Main(string[] args)
    {
        // create an instance of Employee
        Employee employee = new Employee() { FirstName = "john", LastName = "Mary" };

        //use polymorphism: declare an IQuittable object and assign the Employee instance to it
        Interface.IQuittable quittable = (Interface.IQuittable)employee;

        //call the quit method using the IQuittable interface reference
        quittable.Quit();

        //wait for user input before closing the console window 
        Console.ReadLine();
    }
}
// using 

internal class Employee
{
    internal string FirstName;

    public string LastName { get; internal set; }
}

namespace Interface
{
    //define an interface named IQuittable
    public interface IQuittable
    {
        // declare a method quit with no return type (void)
        void Quit();
    }
    // create an employee class that implements the IQuittable interface
    public class Employee : IQuittable
    {
        //properties for employee first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //implement the quit method defined in the interface
        public void Quit()
        {
            //display a message when the employee quits
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}
