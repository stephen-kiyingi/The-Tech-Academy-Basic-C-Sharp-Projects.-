using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentCodeFirstAPP
{
    internal class Program
    {
        private static readonly object Context;

        static void Main(string[] args)
        {
            using (SchoolContext context = new SchoolContext())
            {
                var student = new Student
                {
                    Name = "stephen"
                };
            }
            Context.Students.Add(student);
            Context.SaveChanges();

            Console.WriteLine("Student added successfuly.");
        }

        
    }
}
