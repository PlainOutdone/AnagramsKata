using AnagramsKata.Domain.AnagramChecker;
using System;
using Xunit;

namespace AnagramsKata.UnitTests
{
    public class AnagramCheckerTests
    {
        [Fact]
        public void WhenProvidedAWordOfADifferentLengthReturnFalse()
        {
            AnagramChecker ac = new AnagramChecker();
            string first = "testy";
            string second = "bestywesty";

            Assert.False(ac.IsAnagram(first, second));
        }

        [Fact]
        public void WhenProvidedAWordThatContainsDifferentCharactersReturnFalse()
        {
            AnagramChecker ac = new AnagramChecker();
            string first = "besty";
            string second = "westy";

            Assert.False(ac.IsAnagram(first, second));
        }

        [Fact]
        public void WhenIProvideAnAnagramReturnTrue()
        {
            AnagramChecker ac = new AnagramChecker();
            string first = "redrum";
            string second = "murder";

            Assert.True(ac.IsAnagram(first, second));
        }
    }
}
