using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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

        public void Multiply(double number)
        {
            Result *= number;
        }

        public void Divide(double number)
        {
            if (number != 0)
                Result /= number;
            else
                Console.WriteLine("0-t huvaagdahgui.");
        }
        public void Clear()
        {
            Result = 0;
        }
    }
}
