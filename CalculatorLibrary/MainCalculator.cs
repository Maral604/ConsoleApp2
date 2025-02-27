using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Тооны машинтай холбоотой үндсэн үйлдлүүдийг хэрэгжүүлдэг class.
    /// </summary>
    public class MainCalculator : CalculatorBase, ICalculator
    {
        /// <summary>
        /// Байгуулагч Function 
        /// </summary>

        public MainCalculator() { 
            Result = 0;
        }
        /// <summary>
        /// Байгуулагч Function
        /// </summary>
        /// <param name="result">Анхны утга</param>
        public MainCalculator(double result)
        {
            Result = result;
        }
        /// <summary>
        /// Өгөгдсөн тоог одоогийн утгад нэмнэ.
        /// </summary>
        /// <param name="number">Нэмэгдэх тоо.</param>
        public void Add(double number)
        {
            Result += number;
        }

        /// <summary>
        /// Өгөгдсөн тоог одоогийн утгаас хасна.
        /// </summary>
        /// <param name="number">Хасагдах тоо.</param>
        public void Sub(double number)
        {
            Result -= number;
        }

        /// <summary>
        /// Тооны машины санах ойг цэвэрлэнэ.
        /// </summary>
        public void Clear()
        {
            Result = 0;
        }
    }
}

