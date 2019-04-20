using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionKata
{
    [TestFixture]
    public class UrnfieldConversionTests
    {
        [Test]
        public void TestArabicToUrnfield_1()
        {
            Assert.AreEqual(@"/", Conversion.ArabicToUrnfield(1));
        }

        [Test]
        public void TestArabicToUrnfield_2()
        {
            Assert.AreEqual(@"//", Conversion.ArabicToUrnfield(2));
        }

        [Test]
        public void TestArabicToUrnfield_5()
        {
            Assert.AreEqual(@"\", Conversion.ArabicToUrnfield(5));
        }

        [Test]
        public void TestArabicToUrnfield_6()
        {
            Assert.AreEqual(@"/\", Conversion.ArabicToUrnfield(6));
        }

        [Test]
        public void TestArabicToUrnfield_7()
        {
            Assert.AreEqual(@"//\", Conversion.ArabicToUrnfield(7));
        }

        [Test]
        public void TestArabicToUrnfield_29()
        {
            Assert.AreEqual(@"////\\\\\", Conversion.ArabicToUrnfield(29));
        }

        [Test]
        public void TestUrnFieldToArabic_17()
        {
            Assert.AreEqual(17, Conversion.UrnfieldToArabic(@"//\\\"));
        }
    }
}
