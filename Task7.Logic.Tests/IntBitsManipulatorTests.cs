using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task7.Logic.Tests
{
    [TestClass]
    public class IntBitsManipulatorTests
    {
        [TestMethod]
        public void BitInsertion_Nums8And15Pos0And0_9Returned()
        {
            int expected = 9;
            int actual = IntInsertion.BitInsertion(8, 15, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BitInsertion_Nums0And15Pos30And30_1073741824Returned()
        {
            int expected = 1073741824;
            int actual = IntInsertion.BitInsertion(0, 15, 30, 30);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BitInsertion_Nums0And15Pos0And30_15Returned()
        {
            int expected = 15;
            int actual = IntInsertion.BitInsertion(0, 15, 0, 30);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BitInsertion_Nums15AndMinus15Pos0And4_31Returned()
        {
            int expected = 31;
            int actual = IntInsertion.BitInsertion(15, -15, 0, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BitInsertion_Nums15AndMaxValuePos3And5_63Returned()
        {
            int expected = 63;
            int actual = IntInsertion.BitInsertion(15, int.MaxValue, 3, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BitInsertion_NegativePositions_ExceptionRaised()
        {
            int actual = IntInsertion.BitInsertion(15, 15, -5, -2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BitInsertion_jLessThani_ExceptionRaised()
        {
            int actual = IntInsertion.BitInsertion(15, 15, 6, 2);
        }
    }
}
