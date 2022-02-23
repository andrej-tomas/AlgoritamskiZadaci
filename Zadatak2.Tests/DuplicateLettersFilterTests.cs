using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadatak2.StringFilters;

namespace Zadatak2.Tests;

[TestClass]
public class DuplicateLettersFilterTests
{
    [TestMethod]
    public void DuplicateLettersFilter_Word_ReturnsFilteredWord()
    {
        var word = "aaabbbcvcntrt";
        var expected = "abcvntr";
        var actual = new DuplicatelettersFilter().Filter(word);

        Assert.AreEqual(expected, actual);
    }
}

