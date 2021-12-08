using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionsHomeWork
{
    public static class StringExtention
    {

        public static int SumOfWord(this string sentence, string word)
        {
            int Sum = 0;
            string[] wordbyword = sentence.Split(" ");
            foreach (string item in wordbyword)
            {
                if (item == word)
                {
                    Sum++;
                }
            }
            return Sum;
        }
    }
}
