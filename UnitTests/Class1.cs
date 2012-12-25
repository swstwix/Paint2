using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tools.Helpers;

namespace UnitTests
{
    [TestFixture]
    public class RoteteHelperUnitTests
    {
        [Test]
        public void RotateCorrect0()
        {
            int x = 30;
            int y = 30;
            int x0 = 30;
            int y0 = 30;
            Assert.AreEqual(30, RotateHelper.RotateX(x,y, x0, y0));
            Assert.AreEqual(30, RotateHelper.RotateY(x, y, x0, y0));
        }

        [Test]
        public void RotateCorrect1()
        {
            int x = 0;
            int y = 0;
            int x0 = 30;
            int y0 = 30;
            Assert.AreEqual(60, RotateHelper.RotateX(x, y, x0, y0));
            Assert.AreEqual(0, RotateHelper.RotateY(x, y, x0, y0));
        }
    }
}
