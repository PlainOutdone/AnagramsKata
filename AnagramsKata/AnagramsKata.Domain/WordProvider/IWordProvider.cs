using System.Collections.Generic;

namespace AnagramsKata.Domain.WordProvider
{
   public interface IWordProvider
    {
        List<string> GetWords(string fileLocation);
    }

}
