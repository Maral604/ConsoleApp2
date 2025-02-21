using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class MainCalculator : CalculatorBase,ICalculator
    {
        public double Add(double number)
        {
            Result += number;
            return Result;
        }

        public double Sub(double number)
        {
            Result -= number;
            return Result;
        }
        public void Clear()
        {
            Result = 0;
        }
    }
}
