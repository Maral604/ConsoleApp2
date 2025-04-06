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
        private Memory sanahoi; //Sanah oin objecttoi reference hiih huvisagch
        public MainCalculator() { 
            Result = 0;
            sanahoi = new Memory();
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Memory GetSanahoi()
        {
            return sanahoi;
        }

        /// <summary>
        /// Memory хэсэг дээр хэрэглэгчийн оруулсан тоог нэмэх
        /// </summary>
        /// <param name="value"> Хэрэглэгчийн оруулсан тоо</param>
        public Memoryitem SaveMemory(double value)
        {
            return sanahoi.Save(value);
        }

        /// <summary>
        /// Memory хэсгийг бүгдийг нь арилгах
        /// </summary>
        public void ClearMemory()
        {
            sanahoi.Clear();
        }
    }
}

