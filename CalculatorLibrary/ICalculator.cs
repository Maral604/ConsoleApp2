using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal interface ICalculator
    {
        double Add(double number);
        double Sub(double number);
        void Clear();
    }
}
