using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorLibrary
{
    /// <summary>
    /// Санах ойд хадгалагдсан тоог удирдах класс.
    /// </summary>
    public class Memoryitem : ICalculator
    {
        /// <summary>
        /// Санах ойд хадгалагдсан тоо.
        /// </summary>
        public double SanasanToo { get; private set; }

        /// <summary>
        /// Шинэ санах ойн элемент үүсгэнэ.
        /// </summary>
        /// <param name="sanasanToo">Хадгалах тоо.</param>
        public Memoryitem(double sanasanToo)
        {
            this.SanasanToo = sanasanToo;
        }

        /// <summary>
        /// Санах ойд хадгалагдсан тоонд нэмэх үйлдэл хийнэ.
        /// </summary>
        /// <param name="too">Нэмэх тоо.</param>
        public void Add(double too)
        {
            this.SanasanToo += too;
        }

        /// <summary>
        /// Санах ойд хадгалагдсан тооноос хасах үйлдэл хийнэ.
        /// </summary>
        /// <param name="too">Хасах тоо.</param>
        public void Sub(double too)
        {
            this.SanasanToo -= too;
        }

        /// <summary>
        /// Санах ойд хадгалсан тоог тэглэнэ.
        /// </summary>
        public void Clear()
        {
            this.SanasanToo = 0;
        }
    }
}
