using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadatak1.StringCheckers.Palindrome;

namespace Zadatak1.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        [DataTestMethod]
        [DataRow("anavolimilovana")]
        [DataRow("redivider")]
        [DataRow("rac333car")]
        [DataRow("radar")]
        public void PalindromeChecker_PalindromicWord_ReturnsTrue(string word)
        {
            var checker = new PalindromeChecker();
            var actual = checker.CheckString(word);

            Assert.IsTrue(actual);
        }

        [DataTestMethod]
        [DataRow("anavolimilovanaa")]
        [DataRow("jovanaaovanj")]
        [DataRow("33345333")]
        public void PalindromeChecker_NonPalindromicWord_ReturnsFalse(string word)
        {
            var checker = new PalindromeChecker();
            var actual = checker.CheckString(word);

            Assert.IsFalse(actual);
        }
    }
}