
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestCalculator
{
    /// <summary>
    /// Санах ойн үйлдлүүдийг шалгах тестийн класс.
    /// </summary>
    [TestClass]
    public sealed class MemoryTest
    {
        /// <summary>
        /// Санах ойд тоо хадгалах үйлдлийг шалгана.
        /// </summary>
        [TestMethod]
        public void Save_NumberToMemory()
        {
            Memory memory = new Memory();
            Memoryitem savedItem = memory.Save(3);
            Assert.AreEqual(1, memory.GetAll().Count); // Санах ойд 1 элемент хадгалагдсан эсэхийг шалгана.
            Assert.AreEqual(3, savedItem.SanasanToo);
        }

        /// <summary>
        /// Санах ойд хадгалсан бүх тоонуудыг авах тест.
        /// </summary>
        [TestMethod]
        public void GetAll_MemoryItems()
        {
            Memory memory = new Memory();
            memory.Save(8);
            memory.Save(3);
            memory.Save(17);
            List<Memoryitem> items = memory.GetAll();
            Assert.AreEqual(3, items.Count);
            Assert.AreEqual(8, items[0].SanasanToo);
            Assert.AreEqual(3, items[1].SanasanToo);
            Assert.AreEqual(17, items[2].SanasanToo);
        }

        /// <summary>
        /// Санах ойг цэвэрлэх үйлдлийг шалгах тест.
        /// </summary>
        [TestMethod]
        public void Clear_Memory()
        {
            Memory memory = new Memory();
            memory.Save(1);
            memory.Save(2);
            memory.Clear();
            Assert.AreEqual(0, memory.GetAll().Count); // Санах ой хоосон болсон эсэхийг шалгана.
        }
    }
}
