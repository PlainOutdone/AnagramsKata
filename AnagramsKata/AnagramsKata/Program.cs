using System;
using System.Linq;
using AnagramsKata.Domain.WordProvider;
using System.Collections.Generic;
using AnagramsKata.Domain.AnagramController;
using AnagramsKata.Domain.AlphabeticSorter;
using Microsoft.Extensions.DependencyInjection;
using AnagramsKata.Domain;

namespace AnagramsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnagramController controller = IoC.Container.GetService<IAnagramController>();

            foreach (KeyValuePair<string, string> anagrams in controller.RetrieveAnagrams("wordlist.txt"))
            {
                if (anagrams.Value.Contains(" ")) { Console.WriteLine($" Key : {anagrams.Key} || Words : {anagrams.Value}"); }
            }
            Console.ReadKey();
        }





    }



}