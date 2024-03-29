using DG.NumbersToWords;
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
        public void SingleNumber_DisplaysInWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        public void SpecialNumbersAboveTen_DisplaysInWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(10, "Ten")]
        [TestCase(20, "Twenty")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Forty")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninety")]
        public void MultiplesOfTen_DisplaysInWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(21, "Twenty One")]
        [TestCase(46, "Forty Six")]
        [TestCase(93, "Ninety Three")]
        public void MixTensAndUnits_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(100, "One Hundred")]
        [TestCase(200, "Two Hundred")]
        [TestCase(800, "Eight Hundred")]
        public void Hundreds_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(101, "One Hundred and One")]
        [TestCase(286, "Two Hundred and Eighty Six")]
        [TestCase(915, "Nine Hundred and Fifteen")]
        public void MixHundredsAndTens_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(1001, "One Thousand and One")]
        [TestCase(1852, "One Thousand Eight Hundred and Fifty Two")]
        [TestCase(6011, "Six Thousand and Eleven")]
        public void AddThousands_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(10001, "Ten Thousand and One")]
        [TestCase(10011, "Ten Thousand and Eleven")]
        [TestCase(12523, "Twelve Thousand Five Hundred and Twenty Three")]
        [TestCase(50000, "Fifty Thousand")]
        [TestCase(50002, "Fifty Thousand and Two")]
        [TestCase(57002, "Fifty Seven Thousand and Two")]
        public void AddTensOfThousands_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(100001, "One Hundred Thousand and One")]
        [TestCase(100000, "One Hundred Thousand")]
        [TestCase(600064, "Six Hundred Thousand and Sixty Four")]
        public void AddHundredsOfThousands_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(899901, "Eight Hundred and Ninety Nine Thousand Nine Hundred and One")]
        [TestCase(899900, "Eight Hundred and Ninety Nine Thousand Nine Hundred")]
        [TestCase(899912, "Eight Hundred and Ninety Nine Thousand Nine Hundred and Twelve")]
        [TestCase(999999, "Nine Hundred and Ninety Nine Thousand Nine Hundred and Ninety Nine")]
        public void MaxNumbers_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }

        [Test]
        [TestCase(-0, "Zero")]
        [TestCase(-1, "Minus One")]
        [TestCase(-999919, "Minus Nine Hundred and Ninety Nine Thousand Nine Hundred and Nineteen")]
        [TestCase(-999999, "Minus Nine Hundred and Ninety Nine Thousand Nine Hundred and Ninety Nine")]
        public void MinusNumbers_ShowsCorrectWords(int number, string expectedWordString)
        {
            //Arrange
            var converterService = new NumberConverterService();

            //Act
            var wordString = converterService.ConvertNumberToWord(number);

            //Assert
            Assert.That(wordString, Is.EqualTo(expectedWordString));
        }
    }
}