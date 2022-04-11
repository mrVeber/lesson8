using System;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\lessons itmo\lesson8\lesson8\task2\numbers.txt";
            Random rnd = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(0, 50));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int numbers = Convert.ToInt32(sr.ReadLine());
                    sum += numbers;
                }
            }
            Console.WriteLine($"{sum}");
            Console.ReadKey();
        }
    }
}
