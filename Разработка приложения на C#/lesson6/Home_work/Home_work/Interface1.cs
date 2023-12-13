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

        //event EventHandler<EventArgs> GotResult1;

        int Sum(int value);

        double Sum(double value);

        int Substruct(int value);

        double Substruct(double value);

        int Multiply(int value);

        double Multiply(double value);

        int Divide(int value);

        double Divide(double value);

        void CanselLast();
    }
}
