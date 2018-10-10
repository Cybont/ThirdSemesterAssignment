using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeightConverter;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GramsToOuncesTest()
        {
           Assert.AreEqual(0.035274, MyConverter.GramsToOunces(1), 0.1);
        }
        [TestMethod]
        public void OuncesToGramsTest()
        {
            Assert.AreEqual(28.34952, MyConverter.OuncesToGrams(1), 0.1);
        }
    }
}
