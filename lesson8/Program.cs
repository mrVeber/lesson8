using System;
using System.IO;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\lessons itmo";
            string[] files = Directory.GetFiles(path, "*.exe", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                Console.WriteLine($"{file}");
            }
            Console.ReadKey();
        }
    }
}
