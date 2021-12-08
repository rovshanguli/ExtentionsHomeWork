using System;

namespace ExtentionsHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Salam Cavid . Necesen Cavid Cavid ";
            int count = sentence.SumOfWord("Cavid");
            Console.WriteLine(count);
        }
    }
}
