using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class MathOperation1
    {
        //create a method that takes two intergers as parameters
        //make one parameter optional by providing a default value
        public int MathOperation(int i, int j = 1)
        {
            //perform multiplication on intergers and return the result 
            int result = i * j;
            return result;
        }

    }
}
