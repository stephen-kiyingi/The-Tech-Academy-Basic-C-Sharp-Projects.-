using System;
using method_class_assignment;

class Program
{
    static void Main(string[] args)
    {
        //instantiate the MathHandler class to access its methods.
        MathHandler handler = new MathHandler();
        //call the processNumbers method using positional arguments.
        handler.ProcessNumbers(5, 10); //number1 = 5, number2 = 10

        //call the ProcessNumbers method using named parameters
        handler.ProcessNumbers(number1: 7, number2: 14);// number1 = 7, number2 =14

        Console.ReadLine();
    }
}
