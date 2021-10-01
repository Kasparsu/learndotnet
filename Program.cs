using System;
using System.Linq;
using System.Collections.Generic;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            numbers[0] = 333;
            Console.WriteLine(numbers[0]);
            numbers.Insert(10, 444); // indeks peab olema addiga loodud
            Console.WriteLine(numbers[10]);
            bool contains = numbers.Contains(2);
            Console.WriteLine(contains);

            foreach(int num in numbers){
                Console.WriteLine(num);
            }
            var names = new List<string>()
            {
                "Kaspar",
                "Martin",
                "Suursalu"
            };
            Console.WriteLine(names.Count);
        }
    }
}
