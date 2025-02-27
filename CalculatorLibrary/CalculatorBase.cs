using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    //Үндсэн суурь тооны машины мэдээлэл агуулсан класс
    public abstract class CalculatorBase
    {
        /// <summary>
        /// Тооцооллоос гарсан үр дүн
        /// </summary>
        public double Result { get; set; }
    }
}
