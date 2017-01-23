using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(11, Class1.Add(3, 8));
        }
        [Test]
        public void Minus()
        {
            Assert.AreEqual(6, Class1.Minus(8, 2));
        }
    }
}
