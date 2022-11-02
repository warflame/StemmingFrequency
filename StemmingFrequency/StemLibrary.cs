using System;
using System.Collections.Generic;
using System.Text;

namespace StemmingFrequency
{
    public class StemLibrary
    {
        public static IDictionary<string, string> stemLibraryDictionary = new Dictionary<string, string>();

        public StemLibrary()
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
        public string GetStemWord(string inputString)
        {
            inputString = inputString.ToLower().Trim();
            if (stemLibraryDictionary.ContainsKey(inputString))
                return stemLibraryDictionary[inputString];
            return inputString;
        }
    }
}
