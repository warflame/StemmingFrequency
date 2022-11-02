using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StemmingFrequency
{
    public class WordFrequency
    {
        public int GetWordFrequency(string userInputWord, string stemWord, string[] paragraphWordList)
        {
            Helper helper = new Helper();
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
                    string paragraphWord = helper.RemovePunctuation(paragraphWordList[i].ToLower().Trim());

                    //Count if the input word is a exact match
                    if (userInputWord == paragraphWord)
                    {
                        stemCount++;
                    }
                    else if (paragraphWord.StartsWith(stemWord))
                    {
                        //Check the library againts the user input
                        if (StemLibrary.stemLibraryDictionary.ContainsKey(paragraphWord))
                        {
                            //Check user input word stemmed form is the same as the current word 
                            if (StemLibrary.stemLibraryDictionary[paragraphWord] == stemWord)
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
