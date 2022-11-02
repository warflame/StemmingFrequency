using System;
using System.Collections.Generic;

namespace StemmingFrequency
{
    public class StemmingFrequencyMain
    {
        public static void Main(string[] args)
        {
            Helper helper = new Helper();
            string[] paragraphWordList = helper.GetParagraphWordList();

            Console.WriteLine("Please Insert a text : ");
            string userInputWord = Console.ReadLine();

            int stemCount = GetWordFrequency(userInputWord, paragraphWordList);
            Console.WriteLine($"\nWord: {userInputWord} \t Frequency: {stemCount}");


            Console.WriteLine("\n\nEnter \"y\" to restart the program and \"n\" to exit the Program");
            string selectedOption = Console.ReadLine();
            if (selectedOption == "y")
            {
                Console.Clear();
                Main(args);
            }

        }

        public static int GetWordFrequency(string userInputWord, string[] paragraphWordList)
        {
            StemLibrary stemLibrary = new StemLibrary();
            string stemWord = stemLibrary.GetStemWord(userInputWord);

            WordFrequency findWordFrequency = new WordFrequency();
            return findWordFrequency.GetWordFrequency(userInputWord, stemWord, paragraphWordList);
        }
    }
}
