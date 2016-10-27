using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5.Logic;

namespace Task5.Logic.MSUnitTests
{
    [TestClass]
    public class ArraySearcherTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LeftRightEqualIndex_NullArray_NullExceptionRaised()
        {
            ArraySearcher.LeftRightEqualIndex(null);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Arrays.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task5.Logic.MSUnitTests\\Arrays.xml")]
        [TestMethod]
        public void LeftRightEqualIndexTests()
        {
            int[] array = TestContext.DataRow["array"].ToString().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            int? actual = ArraySearcher.LeftRightEqualIndex(array);
            Assert.AreEqual(expected, actual);
        }

    }
}
