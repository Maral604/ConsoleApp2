using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {
        void Add(double number);
        void Sub(double number);
        void Multiply(double number);
        void Divide(double number);
        void Clear();
    }
}
