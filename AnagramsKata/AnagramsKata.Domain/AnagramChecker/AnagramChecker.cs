using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramsKata.Domain.AnagramChecker
{
    public class AnagramChecker : IAnagramChecker
    {
        public bool IsAnagram(string userInput, string dictionaryInput)
        {
            if (userInput.Length != dictionaryInput.Length) { return false; }
            List<Char> lettersLeft = dictionaryInput.ToCharArray().ToList();

            foreach (char c1 in userInput.ToCharArray())
            {
                if (lettersLeft.Contains(c1))
                {
                    lettersLeft.Remove(c1);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }

}
