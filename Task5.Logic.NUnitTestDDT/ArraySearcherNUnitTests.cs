using NUnit.Framework;
using Task5.Logic;

namespace Task5.Logic.NUnitTestDDT
{
    [TestFixture]
    public class ArraySearcherNUnitTests
    {
        static object[] LeftRightEqualIndexCases = {
                                                       new object[] {new int[] {2, 3, 1, 1}, 1},
                                                       new object[] {new int[] {1, 100, 50, -51, 1, 1}, 1 },
                                                       new object[] {new int[] { 1, 2, 3, 4, 3, 2, 1 }, 3 }
                                                   };

        [Test, TestCaseSource("LeftRightEqualIndexCases")]
        public void LeftRightEqualIndexTest(int[] array, int result)
        {
            Assert.AreEqual(ArraySearcher.LeftRightEqualIndex(array), result);
        }
    }
}
