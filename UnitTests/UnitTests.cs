using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        public UnitTests()
        {
        }

        [TestMethod]
        public void Test_IsScalene()
        {
            var result = Program.GetTriangleType(1, 2, 3);
            Assert.IsTrue(result == Constants.SCALENE);

            result = Program.GetTriangleType(2, 1, 3);
            Assert.IsTrue(result == Constants.SCALENE);

            result = Program.GetTriangleType(3, 2, 1);
            Assert.IsTrue(result == Constants.SCALENE);
        }

        [TestMethod]
        public void Test_IsEquilateral()
        {
            var result = Program.GetTriangleType(2, 2, 2);
            Assert.IsTrue(result == Constants.EQUILATERAL);
        }

        [TestMethod]
        public void Test_IsIsoceles()
        {
            var result = Program.GetTriangleType(2, 2, 3);
            Assert.IsTrue(result == Constants.ISOSCELES);

            result = Program.GetTriangleType(2, 3, 3);
            Assert.IsTrue(result == Constants.ISOSCELES);

            result = Program.GetTriangleType(2, 3, 2);
            Assert.IsTrue(result == Constants.ISOSCELES);
        }
    }
}
