namespace RubCaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("рублей", new RubCase.RubCase().  );
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("рубля", new RubCase.RubCase().  );
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("рубль", new RubCase.RubCase().  );
        }
    }
}