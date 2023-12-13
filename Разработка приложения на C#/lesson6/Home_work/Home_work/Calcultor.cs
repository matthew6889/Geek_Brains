using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class Calcultor : ICalc
    {
        public event EventHandler<EventArgs> GotResult;

        //public event EventHandler<EventArgs> GotResult1;

        public int Result = 0;

        public double Result1 = 0;

        private Stack<int> Results = new Stack<int>();

        private Stack<double> Results1 = new Stack<double>();

        public int Divide(int value)
        {
            Results.Push(Result);
            Result /= value;
            RaiseEvent();
            return Result;
        }

        public double Divide(double value)
        {
            Results.Push(Result);
            Result1 /= value;
            RaiseEvent();
            return Result1;
        }

        public int Multiply(int value)
        {
            Results.Push(Result);
            Result *= value;
            RaiseEvent();
            return Result;
        }

        public double Multiply(double value)
        {
            Results.Push(Result);
            Result1 *= value;
            RaiseEvent();
            return Result1;
        }

        public int Substruct(int value)
        {
            Results.Push(Result);
            Result -= value;
            RaiseEvent();
            return Result;
        }

        public double Substruct(double value)
        {
            Results.Push(Result);
            Result1 -= value;
            RaiseEvent();
            return Result1;
        }

        public int Sum(int value)
        {
            Results.Push(Result);
            Result += value;
            RaiseEvent();
            return Result;
        }

        public double Sum(double value)
        {
            Results.Push(Result);
            Result1 += value;
            RaiseEvent();
            return Result1;
        }

        private void RaiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }

        public void CanselLast()
        {
            if (Results.Count > 0)
            {
                Result = Results.Pop();
                RaiseEvent();
            }
        }
    }
}
