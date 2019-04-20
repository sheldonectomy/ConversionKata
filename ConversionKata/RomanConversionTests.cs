using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata
{
    [TestFixture]
    public class RomanConversionTests
    {
        [Test]
        public void TestArabicToRoman_1()
        {
            Assert.AreEqual("I", Conversion.ArabicToRoman(1));
        }

        [Test]
        public void TestArabicToRoman_2()
        {
            Assert.AreEqual("II", Conversion.ArabicToRoman(2));
        }

        [Test]
        public void TestArabicToRoman_3()
        {
            Assert.AreEqual("III", Conversion.ArabicToRoman(3));
        }

        [Test]
        public void TestArabicToRoman_4()
        {
            Assert.AreEqual("IV", Conversion.ArabicToRoman(4));
        }

        [Test]
        public void TestArabicToRoman_5()
        {
            Assert.AreEqual("V", Conversion.ArabicToRoman(5));
        }

        [Test]
        public void TestArabicToRoman_6()
        {
            Assert.AreEqual("VI", Conversion.ArabicToRoman(6));
        }

        [Test]
        public void TestArabicToRoman_7()
        {
            Assert.AreEqual("VII", Conversion.ArabicToRoman(7));
        }

        [Test]
        public void TestArabicToRoman_8()
        {
            Assert.AreEqual("VIII", Conversion.ArabicToRoman(8));
        }

        [Test]
        public void TestArabicToRoman_9()
        {
            Assert.AreEqual("IX", Conversion.ArabicToRoman(9));
        }

        [Test]
        public void TestArabicToRoman_10()
        {
            Assert.AreEqual("X", Conversion.ArabicToRoman(10));
        }

        [Test]
        public void TestArabicToRoman_11()
        {
            Assert.AreEqual("XI", Conversion.ArabicToRoman(11));
        }

        [Test]
        public void TestArabicToRoman_49()
        {
            Assert.AreEqual("XLIX", Conversion.ArabicToRoman(49));
        }

        [Test]
        public void TestArabicToRoman_53()
        {
            Assert.AreEqual("LIII", Conversion.ArabicToRoman(53));
        }

        [Test]
        public void TestArabicToRoman_1989()
        {
            Assert.AreEqual("MCMLXXXIX", Conversion.ArabicToRoman(1989));
        }
    }
}
