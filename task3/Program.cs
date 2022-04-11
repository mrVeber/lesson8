using System;
using System.IO;

namespace task3
{
    class Program
    {
        static int NumbersOfWords (string path)
        {
            string word = "";
            int numOfWord = 0;
            string[] textArray;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    word += sr.ReadLine();
                }
                textArray = word.Split(' ');
            }
            return numOfWord = textArray.Length;
        }

        static int NumberOfLetter (string path)
        {
         string word = "";
            int numOfWord = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    word += sr.ReadLine();
                }
            }
            return numOfWord = word.Length;
        }

        static int NumberOfString (string path)
        {
            int strimeLine = '\n';
            int lineCounts = 1;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    if (sr.Read() == strimeLine)
                    {
                        lineCounts++;
                    }
                }
            }
            return lineCounts;
        }
        static void Main(string[] args)
        {
            string path = @"D:\lessons itmo\lesson8\lesson8\task3\text.txt";
            Console.WriteLine($"Количество строк в файле равно: {NumberOfString(path)}");
            Console.WriteLine($"Количество символов в файле равно: {NumberOfLetter(path)}");
            Console.WriteLine($"Количество слов в файле равно: {NumbersOfWords(path)}");
            Console.ReadKey();  
        }
    }
}
