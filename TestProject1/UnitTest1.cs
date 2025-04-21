using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(2, 2, 4)]
        public void TestMethod1(int a, int b, int expected)
        {
            var result = MyLibrary.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(2, 4, 0)]
        public void TestMethod2(int a, int b, int expected)
        {
            var result = MyLibrary.Substract(a, b);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(2, 4, 0)]
        public void TestMethod3(int a, int b, int expected)
        {
            var result = MyLibrary.Divide(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}