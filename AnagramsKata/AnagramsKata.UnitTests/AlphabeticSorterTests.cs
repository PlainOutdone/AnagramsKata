using AnagramsKata.Domain.AlphabeticSorter;
using AnagramsKata.Domain.AnagramController;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AnagramsKata.UnitTests
{

    public class AlphabeticSorterTests
    {
        [Fact]
        public void WhenGivenNoWordReturnNothing()
        {
            AlphabeticSorter sorter = new AlphabeticSorter();
            var input = "TESTY";
            var expected = "ESTTY";

            var actual = sorter.SortWord(input);
            Assert.Equal(expected, actual);
        }
    }
}
