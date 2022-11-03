using System;
using System.Collections.Generic;
using System.Linq;

namespace StemLibrary
{
    public class StemLibraryMain
    {
        public static IDictionary<string, string> stemLibraryDictionary = new Dictionary<string, string>();

        public StemLibraryMain()
        {
            InitializeLibrary();
        }

        /// <summary>
        /// Initialize Library
        /// </summary>
        public void InitializeLibrary()
        {
            stemLibraryDictionary.Clear();
            stemLibraryDictionary.Add("following", "follow");
            stemLibraryDictionary.Add("flow", "flow");
            stemLibraryDictionary.Add("classification", "class");
            stemLibraryDictionary.Add("class", "class");
            stemLibraryDictionary.Add("flower", "flower");
            stemLibraryDictionary.Add("friend", "friend");
            stemLibraryDictionary.Add("friendly", "friend");
            stemLibraryDictionary.Add("classes", "class");

            stemLibraryDictionary.Add("flowery", "flower");
            stemLibraryDictionary.Add("flowers", "flower");
            stemLibraryDictionary.Add("flows", "flow");
            stemLibraryDictionary.Add("classify", "class");
            stemLibraryDictionary.Add("friends", "friend");
            stemLibraryDictionary.Add("friendlier", "friend");
            stemLibraryDictionary.Add("friendlies", "friend");

            stemLibraryDictionary.Add("are", "are");
            stemLibraryDictionary.Add("and", "and");
            stemLibraryDictionary.Add("that", "that");
            stemLibraryDictionary.Add("through", "through");

        }

        /// <summary>
        /// Get Stem Word for the given user Input
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public string GetStemWord(string inputString)
        {
            inputString = inputString.ToLower().Trim();
            if (stemLibraryDictionary.ContainsKey(inputString))
                return stemLibraryDictionary[inputString];
            return inputString;
        }

        /// <summary>
        /// Get Stem Frequency by User Input
        /// </summary>
        /// <param name="userInputWord"></param>
        /// <param name="paragraphWordList"></param>
        /// <returns></returns>
        public int GetStemFrequency(string userInputWord, string[] paragraphWordList)
        {
            string stemWord = GetStemWord(userInputWord);

            userInputWord = userInputWord.ToLower().Trim();
            stemWord = stemWord.ToLower().Trim();

            if (string.IsNullOrEmpty(stemWord))
            {
                return 0;
            }
            else
            {
                int stemCount = 0;
                for (int i = 0; i < paragraphWordList.Length; i++)
                {
                    //Remove Punctuations from the string
                    string paragraphWord = paragraphWordList[i].ToLower().Trim().Where(c => !char.IsPunctuation(c)).Aggregate("", (current, c) => current + c);

                    //Count if the input word is a exact match
                    if (userInputWord == paragraphWord)
                    {
                        stemCount++;
                    }
                    else if (paragraphWord.StartsWith(stemWord))
                    {
                        //Check the library againts the user input
                        if (StemLibraryMain.stemLibraryDictionary.ContainsKey(paragraphWord))
                        {
                            //Check user input word stemmed form is the same as the current word 
                            if (StemLibraryMain.stemLibraryDictionary[paragraphWord] == stemWord)
                            {
                                stemCount++;
                            }
                        }
                    }
                }
                return stemCount;
            }
        }

    }
}
