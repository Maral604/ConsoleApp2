using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class MainCalculator : CalculatorBase,ICalculator
    {
        public void Add(double number)
        {
            Result += number;
        }

        public void Sub(double number)
        {
            Result -= number;
        }
        public void Clear()
        {
            Result = 0;
        }
    }
}
