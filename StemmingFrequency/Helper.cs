using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StemmingFrequency
{
    public class Helper
    {
        const string paragraph = "Friends are friendlier friendlies that are friendly and classify the friendly classification class. Flowery flowers flow through following the flower flows.";

        public string[] GetParagraphWordList()
        {
            return paragraph.Split(" ");
        }

        public string RemovePunctuation(string inputString)
        {
            return inputString.ToLower().Trim().Where(c => !char.IsPunctuation(c)).Aggregate("", (current, c) => current + c);
        }
    }
}
