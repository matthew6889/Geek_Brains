using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Calcultor : ICalc
    {
        public event EventHandler<EventArgs> GotResult;

        public int Result = 0;

        private Stack<int> Results = new Stack<int>();

        private Stack<CalcActionLog> actions = new Stack<CalcActionLog>();

        public void Divide(int value)
        {
            //long temp = Result / value;
            //if (temp < int.MinValue)
            //{
            //    actions.Push(new CalcActionLog(CalcAction.Divide, value));
            //    throw new CalculateOperationCauseOverflowException("Переполнение");
            //}
            if (value == 0)
            {
                actions.Push(new CalcActionLog(CalcAction.Divide, value));
                throw new CalculatorDivideByZeroException("Нелья делить на 0", actions);
            }
            Results.Push(Result);
            Result /= value;
            RaiseEvent();
            //return Result;
        }

        public void Multiply(int value)
        {
            long temp = value * Result;
            if (temp > int.MaxValue)
            {
                actions.Push(new CalcActionLog(CalcAction.Multiply, value));
                throw new CalculateOperationCauseOverflowException("Переполнение", actions);
            }
            Results.Push(Result);
            Result *= value;
            RaiseEvent();
            //return Result;
        }

        public void Substruct(int value)
        {
            long temp = Result - value;
            if (temp < int.MinValue || (Result == int.MinValue && value == int.MaxValue))
            {
                actions.Push(new CalcActionLog(CalcAction.Substruct, value));
                throw new CalculateOperationCauseOverflowException("Переполнение", actions);
            }
            Results.Push(Result);
            Result -= value;
            RaiseEvent();
            //return Result;
        }

        public void Sum(int value)
        {
            ulong temp = (ulong) (value + Result);
            if (temp > int.MaxValue)
            {
                actions.Push(new CalcActionLog(CalcAction.Sum, value));
                throw new CalculateOperationCauseOverflowException("Переполнение", actions);
            }
            Results.Push(Result);
            Result += value;
            RaiseEvent();
            //return Result;
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
