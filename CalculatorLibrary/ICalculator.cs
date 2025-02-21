using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal interface ICalculator
    {
        void Add(double number);
        void Sub(double number);
        void Clear();
    }
}
