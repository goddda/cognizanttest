using System;
using System.Collections.Generic;
using System.Text;
using Mathh;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    class MathTests
    {
        [Test]
        void Math_whentwocorrectnumbersprovided_testshouldpass()
        {
            var n1 = 2;
            var n2 = 3;
            var expectedSum = 5;

            var math = new MathManager();
            var result = math.Add(n1, n2);

            Assert.AreEqual(expectedSum, result);
        }
    }
}
