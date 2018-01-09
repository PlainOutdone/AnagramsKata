using AnagramsKata.Domain.WordProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramsKata.IntegrationTests.Mock
{
    /// <summary>
    /// To test our outputs, we need a controllable input.
    /// </summary>
    class MockWordProvider : IWordProvider
    {
        public List<string> GetWords(string fileLocation)
        {
            return new List<string>()
            {
                "apple",
                "pear",
                "orange",
                "reap"
            };
        }
    }
}
