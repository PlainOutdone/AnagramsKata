using AnagramsKata.Domain.AlphabeticSorter;
using AnagramsKata.Domain.WordProvider;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramsKata.Domain.AnagramController
{
    public class AnagramController : IAnagramController
    {
        private IWordProvider _provider;
        private IAlphabeticSorter _sorter;
        public AnagramController(IWordProvider provider, IAlphabeticSorter sorter)
        {
            _provider = provider;
            _sorter = sorter;
        }

        private Dictionary<string, string> outputDict = new Dictionary<string, string>();

        public Dictionary<string, string> RetrieveAnagrams(string dictionaryLocation)
        {

            List<string> lines = _provider.GetWords(dictionaryLocation);
            List<string> outputList = new List<string>();


            foreach (string line in lines)
            {
                var sorted = _sorter.SortWord(line);
                if (outputDict.ContainsKey(sorted))
                {
                    outputDict[sorted] = $"{outputDict[sorted]} {line}";
                }
                else
                {
                    outputDict.Add(sorted, line);
                }
            }

            return outputDict;
        }

    }
}
