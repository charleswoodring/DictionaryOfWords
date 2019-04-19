using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {

//    Create a dictionary with key value pairs to represent words (key) and its definition (value)

            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            //                          key         value
            wordsAndDefinitions.Add("Awesome", "the feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Adversary", "an enemy or opponent");
            wordsAndDefinitions.Add("Climb", "to go upward with gradual or continuous progress");
            wordsAndDefinitions.Add("Thole", "endure");
            wordsAndDefinitions.Add("Coffee", "a hot beverage best enjoyed black");


            //    Use square bracket lookup to get the definition two words and output them to the console
            string firstWord = wordsAndDefinitions["Awesome"];
            string secondWord = wordsAndDefinitions["Climb"];
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);


            //    Loop over dictionary to get the following output:
            //        The definition of [WORD] is [DEFINITION]

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                // Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}