using System.Collections.Generic;
using System.Linq;

namespace AnagramsKata.Domain.AlphabeticSorter
{
    public class AlphabeticSorter : IAlphabeticSorter
    {
       public string SortWord(string word)
        {
            List<char> characters = word.ToCharArray().ToList();
            characters.Sort();
            return new string(characters.ToArray());
        }
    }
}
