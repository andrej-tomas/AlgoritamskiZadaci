using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Zadatak2.StringCounters;

namespace Zadatak2.Tests
{
    [TestClass]
    public class LetterOccurrencesCounterTests
    {
        [TestMethod]
        public void LetterOccurencesCounter_Word_ReturnsDictionary()
        {
            var word = "aaabbbcvcntrt";
            var expected = "a3b3c2v1n1t2r1";

            var actual = new LetterOccurrencesCounter().Count(word);

            Assert.AreEqual(actual, expected);
        }
    }
}