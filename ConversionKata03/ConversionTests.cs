using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata03
{
    [TestFixture]
    public class ConversionTests
    {
        Conversion _conversion;

        [SetUp]
        public void SetUp()
        {
            _conversion = new Conversion();
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0001()
        {
            Assert.AreEqual("I", _conversion.ArabicToRoman(1));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0002()
        {
            Assert.AreEqual("II", _conversion.ArabicToRoman(2));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0004()
        {
            Assert.AreEqual("IV", _conversion.ArabicToRoman(4));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0005()
        {
            Assert.AreEqual("V", _conversion.ArabicToRoman(5));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0006()
        {
            Assert.AreEqual("VI", _conversion.ArabicToRoman(6));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0009()
        {
            Assert.AreEqual("IX", _conversion.ArabicToRoman(9));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0010()
        {
            Assert.AreEqual("X", _conversion.ArabicToRoman(10));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0013()
        {
            Assert.AreEqual("XIII", _conversion.ArabicToRoman(13));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0014()
        {
            Assert.AreEqual("XIV", _conversion.ArabicToRoman(14));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0039()
        {
            Assert.AreEqual("XXXIX", _conversion.ArabicToRoman(39));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0043()
        {
            Assert.AreEqual("XLIII", _conversion.ArabicToRoman(43));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0059()
        {
            Assert.AreEqual("LIX", _conversion.ArabicToRoman(59));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0394()
        {
            Assert.AreEqual("CCCXCIV", _conversion.ArabicToRoman(394));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_0957()
        {
            Assert.AreEqual("CMLVII", _conversion.ArabicToRoman(957));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_2448()
        {
            Assert.AreEqual("MMCDXLVIII", _conversion.ArabicToRoman(2448));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_3499()
        {
            Assert.AreEqual("MMMCDXCIX", _conversion.ArabicToRoman(3499));
        }

        [Test]
        public void ConversionToRomanReturnsCorrectValueFrom_2325()
        {
            Assert.AreEqual("MMCCCXXV", _conversion.ArabicToRoman(2325));
        }
    }
}
