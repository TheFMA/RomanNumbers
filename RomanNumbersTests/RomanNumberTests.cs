using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void Add()
        {
            var RomNum1 = new RomanNumber(45);
            var RomNum2 = new RomanNumber(16);
            var expected = new RomanNumber(61);
            RomanNumber actual = RomNum1 + RomNum2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void Sub()
        {
            var RomNum1 = new RomanNumber(23);
            var RomNum2 = new RomanNumber(83);
            var expected = new RomanNumber(60);
            RomanNumber actual = RomNum2 - RomNum1;
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void Sub_Exception()
        {
            var RomNum1 = new RomanNumber(23);
            var RomNum2 = new RomanNumber(3);
            Assert.ThrowsException<RomanNumberException>(() => (RomNum2 - RomNum1));
        }

        [TestMethod()]
        public void Div()
        {
            var RomNum1 = new RomanNumber(20);
            var RomNum2 = new RomanNumber(4);
            var expected = new RomanNumber(5);
            RomanNumber actual = RomNum1 / RomNum2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void Div_Exception()
        {
            var RomNum1 = new RomanNumber(17);
            var RomNum2= new RomanNumber(5);
            Assert.ThrowsException<RomanNumberException>(() => (RomNum2 / RomNum1));
        }

        [TestMethod()]
        public void Mul()
        {
            var RomNum1 = new RomanNumber(8);
            var RomNum2 = new RomanNumber(6);
            var expected = new RomanNumber(48);
            RomanNumber actual = RomNum1 * RomNum2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber RomNum = new RomanNumber(21);
            string expected = "XXI";
            string actual = RomNum.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber RomNum = new RomanNumber(10);
            RomanNumber expected = new RomanNumber(10);
            RomanNumber clone = (RomanNumber)RomNum.Clone();
            Assert.AreEqual(expected.ToString(), clone.ToString());
        }

        [TestMethod()]
        public void CloneTest_NotSame()
        {
            RomanNumber RomNum = new RomanNumber(8);
            RomanNumber expected = new RomanNumber(10);
            RomanNumber clone = (RomanNumber)RomNum.Clone();
            Assert.AreNotSame(expected, clone);
        }


        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber RomNum = new RomanNumber(7);
            RomanNumber RomNum1 = new RomanNumber(7);
            int expected = 0;
            int actual = RomNum.CompareTo(RomNum1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CompareToTest_NotSame()
        {
            RomanNumber RomNum = new RomanNumber(7);
            RomanNumber RomNum1 = new RomanNumber(8);
            int expected = 0;
            int actual = RomNum.CompareTo(RomNum1);
            Assert.AreNotSame(expected, actual);
        }
    }
}