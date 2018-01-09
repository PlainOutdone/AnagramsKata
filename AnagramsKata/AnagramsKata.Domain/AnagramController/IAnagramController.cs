using System.Collections.Generic;

namespace AnagramsKata.Domain.AnagramController
{
    public interface IAnagramController
    {
        Dictionary<string, string> RetrieveAnagrams( string dictionaryLocation);
    }
}
