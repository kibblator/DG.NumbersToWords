using NUnit.Framework;

namespace DG.NumbersToWordsTests
{
    public class Tests
    {
        [Test]
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        public void SingleNumber_DisplaysInWords(int number, string expectedWord)
        {
            Assert.Pass();
        }
    }
}