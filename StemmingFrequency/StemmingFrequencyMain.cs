using StemLibrary;
using System;
using System.Collections.Generic;

namespace StemmingFrequency
{
    public class StemmingFrequencyMain
    {
        public static void Main(string[] args)
        {
            const string paragraph = "Friends are friendlier friendlies that are friendly and classify the friendly classification class. Flowery flowers flow through following the flower flows.";
            string[] paragraphWordList = paragraph.Split(" ");

            Console.WriteLine("Please Insert a text : ");
            string userInputWord = Console.ReadLine();


            int stemCount = GetStemFrequency(userInputWord, paragraphWordList);
            Console.WriteLine($"\nWord: {userInputWord} \t Frequency: {stemCount}");


            Console.WriteLine("\n\nEnter \"y\" to restart the program and \"n\" to exit the Program");
            string selectedOption = Console.ReadLine();
            if (selectedOption == "y")
            {
                Console.Clear();
                Main(args);
            }

        }


        /// <summary>
        /// Get stem frequency by user Input
        /// </summary>
        /// <param name="userInputWord"></param>
        /// <param name="paragraphWordList"></param>
        /// <returns></returns>
        public static int GetStemFrequency(string userInputWord, string[] paragraphWordList)
        {
            StemLibraryMain stemLibrary = new StemLibraryMain();
            return stemLibrary.GetStemFrequency(userInputWord, paragraphWordList); ;
        }

    }
}
