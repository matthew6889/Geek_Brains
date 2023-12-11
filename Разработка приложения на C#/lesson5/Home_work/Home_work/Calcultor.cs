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

        public int Result = 0;

        private Stack<int> Results = new Stack<int>();

        public int Divide(int value)
        {
            Results.Push(Result);
            Result /= value;
            RaiseEvent();
            return Result;
        }

        public int Multiply(int value)
        {
            Results.Push(Result);
            Result *= value;
            RaiseEvent();
            return Result;
        }

        public int Substruct(int value)
        {
            Results.Push(Result);
            Result -= value;
            RaiseEvent();
            return Result;
        }

        public int Sum(int value)
        {
            Results.Push(Result);
            Result += value;
            RaiseEvent();
            return Result;
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
