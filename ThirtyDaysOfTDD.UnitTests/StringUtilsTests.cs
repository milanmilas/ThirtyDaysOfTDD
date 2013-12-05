using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var charecterToCount = "e";
            var expectedResult = 2;

            var stringUtils = new StringUtils();

            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, charecterToCount);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToCount = "n";
            var expectedResut = 5;

            var stringUtil = new StringUtils();

            int result = stringUtil.FindNumberOfOccurences(sentenceToScan, characterToCount);

            Assert.AreEqual(expectedResut, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            var sentneceToScan = "This should not even be counted as character is actually string";
            var characterToCount = "xx";

            var stringUtil = new StringUtils();

            int reuslt = stringUtil.FindNumberOfOccurences(sentneceToScan, characterToCount);
        }

    }
}
