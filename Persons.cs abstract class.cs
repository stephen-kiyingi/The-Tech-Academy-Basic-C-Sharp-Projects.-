using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class_Assignment
{
    //Create an Abstarct class "Person" with two string properties :FirstName and LastName
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //give it a method SayName().
        public abstract void SayName();
    }
}



