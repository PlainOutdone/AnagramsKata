using AnagramsKata.Domain;
using AnagramsKata.Domain.AlphabeticSorter;
using AnagramsKata.Domain.AnagramController;
using AnagramsKata.Domain.WordProvider;
using AnagramsKata.IntegrationTests.Mock;
using Microsoft.Extensions.DependencyInjection;
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
            IoC.ServiceCollection.AddSingleton<IWordProvider, MockWordProvider>();

            IAnagramController controller = IoC.Container.GetService<IAnagramController>();
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
