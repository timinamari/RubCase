namespace RubCaseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("������", new RubCase.RubCase().  );
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("�����", new RubCase.RubCase().  );
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("�����", new RubCase.RubCase().  );
        }
    }
}