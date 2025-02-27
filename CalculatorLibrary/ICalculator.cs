using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Тооны машинтай холбоотой үйлдлүүдийг агуулсан интерфэйс.
    /// </summary>
    internal interface ICalculator
    {
        /// <summary>
        /// Өгөгдсөн тоог нэмэх.
        /// </summary>
        /// <param name="number">Нэмэгдэх тоо.</param>
        void Add(double number);

        /// <summary>
        /// Өгөгдсөн тоог хасах.
        /// </summary>
        /// <param name="number">Хасагдах тоо.</param>
        void Sub(double number);

        /// <summary>
        /// Санах ойг цэвэрлэх.
        /// </summary>
        void Clear();
    }
}