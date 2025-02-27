using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// Тооны машины санах ойг удирдах класс.
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Санах ойд хадгалагдсан бүх утгуудын жагсаалт.
        /// </summary>
        public List<Memoryitem> memories = new List<Memoryitem>();

        /// <summary>
        /// Санах ойд шинэ утга хадгална.
        /// </summary>
        /// <param name="too">Хадгалах тоо.</param>
        /// <returns>Шинээр хадгалсан санах ойн элемент.</returns>
        public Memoryitem Save(double number)
        {
            Memoryitem item = new Memoryitem(number);
            memories.Add(item);
            return item;
        }

        /// <summary>
        /// Санах ойд хадгалагдсан бүх утгуудыг буцаана.
        /// </summary>
        /// <returns>Санах ойн бүх элементүүдийн жагсаалт.</returns>
        public List<Memoryitem> GetAll()
        {
            return memories;
        }

        /// <summary>
        /// Санах ойг цэвэрлэнэ.
        /// </summary>
        public void Clear()
        {
            memories.Clear();
        }
    }
}



