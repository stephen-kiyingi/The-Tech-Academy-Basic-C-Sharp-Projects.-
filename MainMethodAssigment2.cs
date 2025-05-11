using System;

//program.cs
namespace MainMethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiate the MathMethods2 class
            MathMethods2 math1 = new MathMethods2();
            // call the first method within an in parameter
            Console.WriteLine(math1.MathOp(7));
            //call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(7.3m));
            //call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7"));
        }
    }

}
