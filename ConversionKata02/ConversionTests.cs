using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata02
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
        public void TestConversionConverts_01_Correctly()
        {
            Assert.AreEqual("I", _conversion.ArabicToRoman(1));
        }

        [Test]
        public void TestConversionConverts_02_Correctly()
        {
            Assert.AreEqual("II", _conversion.ArabicToRoman(2));
        }

        [Test]
        public void TestConversionConverts_03_Correctly()
        {
            Assert.AreEqual("III", _conversion.ArabicToRoman(3));
        }

        [Test]
        public void TestConversionConverts_04_Correctly()
        {
            Assert.AreEqual("IV", _conversion.ArabicToRoman(4));
        }

        [Test]
        public void TestConversionConverts_05_Correctly()
        {
            Assert.AreEqual("V", _conversion.ArabicToRoman(5));
        }

        [Test]
        public void TestConversionConverts_06_Correctly()
        {
            Assert.AreEqual("VI", _conversion.ArabicToRoman(6));
        }

        [Test]
        public void TestConversionConverts_07_Correctly()
        {
            Assert.AreEqual("VII", _conversion.ArabicToRoman(7));
        }

        [Test]
        public void TestConversionConverts_09_Correctly()
        {
            Assert.AreEqual("IX", _conversion.ArabicToRoman(9));
        }

        [Test]
        public void TestConversionConverts_10_Correctly()
        {
            Assert.AreEqual("X", _conversion.ArabicToRoman(10));
        }

        [Test]
        public void TestConversionConverts_13_Correctly()
        {
            Assert.AreEqual("XIII", _conversion.ArabicToRoman(13));
        }

        [Test]
        public void TestConversionConverts_14_Correctly()
        {
            Assert.AreEqual("XIV", _conversion.ArabicToRoman(14));
        }

        [Test]
        public void TestConversionConverts_15_Correctly()
        {
            Assert.AreEqual("XV", _conversion.ArabicToRoman(15));
        }

        [Test]
        public void TestConversionConverts_18_Correctly()
        {
            Assert.AreEqual("XVIII", _conversion.ArabicToRoman(18));
        }

        [Test]
        public void TestConversionConverts_34_Correctly()
        {
            Assert.AreEqual("XXXIV", _conversion.ArabicToRoman(34));
        }

        [Test]
        public void TestConversionConverts_446_Correctly()
        {
            Assert.AreEqual("CDXLVI", _conversion.ArabicToRoman(446));
        }

        [Test]
        public void TestConversionConverts_3724_Correctly()
        {
            Assert.AreEqual("MMMDCCXXIV", _conversion.ArabicToRoman(3724));
        }
    }
}
