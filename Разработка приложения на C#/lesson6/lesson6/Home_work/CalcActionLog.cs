using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class CalcActionLog
    {
        public CalcAction CalcAction { get; private set; }
        
        public int CalcArgument { get; private set; }

        public CalcActionLog(CalcAction calcAction,int calcArgument)
        {
            CalcAction = calcAction;
            CalcArgument = calcArgument;
        }
    }
}
