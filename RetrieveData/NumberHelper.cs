using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveData
{
    public delegate void ResultCallback(int results);
    class NumberHelper
    {
        private int _Number;
        private ResultCallback _resultCallback;
        public NumberHelper(int Number,ResultCallback resultCallback)
        {
            _Number = Number;
            _resultCallback = resultCallback;
        }
        //This is the Thread function which will calculate the sum of the numbers
        public void CalculateSum()
        {
            int Result = 0;
            for (int i = 1; i <= _Number; i++)
            {
                Result = Result + i;
            }
            //Before the end of the thread function call the callback method
            if (_resultCallback != null)
            {
                _resultCallback(Result);
            }
        }

    }
}
