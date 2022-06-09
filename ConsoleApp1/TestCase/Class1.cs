using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment_2;

namespace Testing_A1
{
    [TestFixture]
    public class A1Test
    {
        [Test]
        [TestCase(5, 6, 22)]
        [TestCase(1, 1, 4)]
        [TestCase(999, 1999, 5996)]
        public void GetPerimeterMethodTest(int l, int w, int expected)
        {
            Assignment_2.Rectangle _rect = new Assignment_2.Rectangle(w, l);
            int result = _rect.GetPerimeter();
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1, 20, 20)]
        [TestCase(30, 1, 30)]
        [TestCase(40, 40, 1600)]
        public void GetAreaMethodTest(int l, int w, int expected)
        {
            Assignment_2.Rectangle _rect = new Assignment_2.Rectangle(w, l);
            int result = _rect.GetArea();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetLength10Result10()
        {
            Assignment_2.Rectangle _rect = new Assignment_2.Rectangle(5, 10);
            int result = _rect.GetLength();
            Assert.AreEqual(10, result);
        }
        [Test]
        public void GetWidth5Result5()
        {
            Assignment_2.Rectangle _rect = new Assignment_2.Rectangle(5, 10);
            int result = _rect.GetWidth();
            Assert.AreEqual(5, result);
        }
        [Test]
        [TestCase(6, 6)]
        [TestCase(0, -1)]
        [TestCase(-40, -1)]
        public void SetLengthTest(int l, int expected)
        {
            Assignment_2.Rectangle _rect = new Assignment_2.Rectangle(5, 10);
            int result = _rect.SetLength(l);
            Assert.AreEqual(expected, result);
        }
        [Test]
        [TestCase(6, 6)]
        [TestCase(0, -1)]
        [TestCase(-40, -1)]
        public void SetWidthTest(int w, int expected)
        {
            Assignment_2.Rectangle _rect = new Assignment_2.Rectangle(5, 10);
            int result = _rect.SetWidth(w);
            Assert.AreEqual(expected, result);
        }



    }
}
