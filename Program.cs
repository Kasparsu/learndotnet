using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a comment
            // int num1 = 4, // can assign multiple variables while initializing
            //     num2 = 2,
            //     num3 = 1;
            double number = 1;
            number = number + 1;
            number += 3;
            number -= 2;
            number++;
            number--;
            number = 17;
            number = number % 2; //modulo
            number = 1.2;
            int num1 = (int) number;
            number = 0.2 + 0.2;
            //char letter = 'a';
            string word = "hello\n\n\n\t    \\ \aworld!";
            word = @"hello\n\n\n\t    \\ \aworld!";
            word = "hello" + " world!";
            word += "!!!!!!!!!!";
            bool foo = true; // foo, bar, baz
            foo = false;
            const double PI = 3.1415;
            //int camelCase, StudlyCaps, snake_case; //different naming schemes
            word = word.ToUpper();
            Console.WriteLine(word);
        }
    }
}
