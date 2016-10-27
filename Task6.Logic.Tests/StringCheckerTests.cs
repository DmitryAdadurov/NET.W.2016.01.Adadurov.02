using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6.Logic;

namespace Task6.Logic.Tests
{
    [TestClass]
    public class StringCheckerTests
    {
        [TestMethod]
        public void RemoveRepeatedCharacters_xyaabbbccccdefwwAndxxxxyyyyabklmopq_abcdefklmopqwxyExpected()
        {
            string expected = "abcdefklmopqwxy";
            string actual = StringChecker.RemoveRepeatedCharacters("xyaabbbccccdefww" + "xxxxyyyyabklmopq");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveRepeatedCharacters_abcdefghijklmnopqrstuvwxyzTwice_abcdefghijklmnopqrstuvwxyzExpected()
        {
            string expected = "abcdefghijklmnopqrstuvwxyz";
            string actual = StringChecker.RemoveRepeatedCharacters("abcdefghijklmnopqrstuvwxyz" + "abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveRepeatedCharacters_Digits_StringWithoutDigitsReturned()
        {
            string expected = "abcdefghijklmnopqrstuvwxyz";
            string actual = StringChecker.RemoveRepeatedCharacters("abcdefgh2ijklmnopqrs444444tuvwxyz" + "abcdefghijk000000000lmnopqrstuvwxyz");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveRepeatedCharacters_Null_ExceptionRaised()
        {
            StringChecker.RemoveRepeatedCharacters(null);
        }

        [TestMethod]
        public void RemoveRepeatedCharacters_EmtpyString_ReturnedEmptyString()
        {
            string actual = StringChecker.RemoveRepeatedCharacters(String.Empty);
            Assert.AreEqual(String.Empty, actual);
        }

    }
}
