﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class MemoryItem
    {
        public double Value { get; private set; }
        public MemoryItem(double value)
        {
            Value = value;
        }
    }
}
