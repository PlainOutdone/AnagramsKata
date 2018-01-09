using System.Collections.Generic;
using System.Linq;

namespace AnagramsKata.Domain.WordProvider
{
    public class WordProvider : IWordProvider
    {
        public List<string> GetWords(string fileLocation)
        {
            return System.IO.File.ReadAllLines(fileLocation).ToList();
        }
    }

}
