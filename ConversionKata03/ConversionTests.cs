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

    }
}
