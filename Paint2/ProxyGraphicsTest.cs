using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Paint2
{
    [TestFixture]
    class ProxyGraphicsTest
    {
        class Comparer : IEqualityComparer<Point>
        {
            public bool Equals(Point x, Point y)
            {
                return (x.X == y.X) && (x.Y == y.Y);
            }

            public int GetHashCode(Point obj)
            {
                return 31*obj.X + obj.Y;
            }
        }

        [Test]
        public void HashSetWorkinCorrect()
        {
            var hashset = new HashSet<Point>(new Comparer());
            hashset.Add(new Point()
            {
                X = 3,
                Y = 3
            });
            Assert.IsTrue(hashset.Contains(new Point()
            {
                X = 3,
                Y = 3
            }));
        }
    }
}
