using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionsHomeWork
{
    public static class StringExtention
    {

        public static int SumOfWord(this string sentence, string word)
        {
            int sumofword = 0;
            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence.Contains(word))
                {
                    sumofword++;
                }
            }
            return sumofword;
        }
    }
}
