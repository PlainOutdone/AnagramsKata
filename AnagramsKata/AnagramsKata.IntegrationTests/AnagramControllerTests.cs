using AnagramsKata.Domain.AlphabeticSorter;
using AnagramsKata.Domain.AnagramChecker;
using AnagramsKata.Domain.AnagramController;
using AnagramsKata.IntegrationTests.Mock;
using System;
using System.Collections.Generic;
using Xunit;

namespace AnagramsKata.IntegrationTests
{
    public class AnagramControllerTests
    {
        [Fact]
        public void WhenProvidedAListEnsureAllItemsArePairedCorrectly()
        {
            //Ideally this would use the same ioc as the main project to ensure we're testing the same implementations
            IAnagramController controller = new AnagramController(new AnagramChecker(), new MockWordProvider(), new AlphabeticSorter());
            Dictionary<string, string> expected = new Dictionary<string, string>
            {
                {"aelpp", "apple" },
                {"aepr","pear reap" },
                {"aegnor","orange" },

            };

            var actual = controller.RetrieveAnagrams("notused");

            Assert.Equal(expected, actual);
        }
    }
}
