﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal interface ICalc
    {
        event EventHandler<EventArgs> GotResult;

        void Sum(int value);

        void Substruct(int value);

        void Multiply(int value);

        void Divide(int value);

        void CanselLast();
    }
}
