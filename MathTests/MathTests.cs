using Mathh;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class MathTests
    {

        [TestMethod]
        public void Math_whentwocorrectnumbersprovided_testshouldpass()
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