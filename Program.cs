using System;
using System.IO;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello files!asfasfsafa";
            File.WriteAllText("file.txt", text);
            text = "next line";
            File.AppendAllText("file.txt", text);
            text = File.ReadAllText("file.txt");
            Console.Write(text);
        }
    }
}
