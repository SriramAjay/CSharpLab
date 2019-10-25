using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolveTypeSaftyWithParameter
{
    /*As you can see we created the above Number Helper class with one private variable, one parameterized constructor and one method. 
     * The private variable _Number is going to hold the target number. 
     * The constructor takes one input parameter of integer type and then it assigns that value to the private variable. 
     * So, while we are creating the instance of NumberHelper class we need to supply the Number value. Finally, 
     * the DisplayNumbers function is used to display the values starting from 1 to the value that is present in the _Number variable.
     */
    public class NumberHelper
    {
        int _Number;

        public NumberHelper(int Number)
        {
            _Number = Number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _Number; i++)
            {
                Console.WriteLine("value : " + i);
            }
        }
    }

}
