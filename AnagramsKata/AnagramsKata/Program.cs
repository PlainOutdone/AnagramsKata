using System;
using System.Linq;
using AnagramsKata.Domain.WordProvider;
using System.Collections.Generic;
using AnagramsKata.Domain.AnagramChecker;
using AnagramsKata.Domain.AnagramController;
using AnagramsKata.Domain.AlphabeticSorter;

namespace AnagramsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI in console apps... :/
            IAnagramController controller = new AnagramController(new AnagramChecker(), new WordProvider(), new AlphabeticSorter());
            foreach (KeyValuePair<string,string> anagrams in controller.RetrieveAnagrams("wordlist.txt"))
            {
                if (anagrams.Value.Contains(" ")) { Console.WriteLine($" Key : {anagrams.Key} || Words : {anagrams.Value}"); }
            }
            Console.ReadKey();
        }



    }
}