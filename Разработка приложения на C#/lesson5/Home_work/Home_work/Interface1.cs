using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal interface ICalc
    {
        event EventHandler<EventArgs> GotResult;

        int Sum(int value);

        int Substruct(int value);

        int Multiply(int value);

        int Divide(int value);

        void CanselLast();
    }
}
