using System;
using System.Linq;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10]; //10 väärtusega array
            int[] numbers = {1, 2, 3, 4, 5};
            numbers[0] = 5;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(nums.Length);
            // try{
            //      Console.WriteLine("sisesta number:");
            //     int numLength = int.Parse(Console.ReadLine());
            //     int[] nums2 = new int[numLength];
            //     Console.WriteLine(nums2.Length);
            // } catch {
                
            // }

            for(int i = 0; i<numbers.Length; i++){
                int num2 = numbers[i];
                Console.WriteLine(num2);
            }
            foreach(int num in numbers){
                Console.WriteLine(num);
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);
            int max = numbers.Max();
            Console.WriteLine(max);
            int min = numbers.Min();
            Console.WriteLine(min);
            Array.Sort(numbers);
            foreach(int num in numbers){
                Console.WriteLine(num);
            }
            
            Console.WriteLine(numbers[3]);
            string[] names = {"Kaspar", "Martin", "Suursalu", "Meelis", "Manivald"};
            
            Console.WriteLine(names[3]);
            int[,] matrix = 
            { 
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };
            Console.WriteLine(matrix[1,2]);
            int[,,] array3d = {{{1}}};
            Console.WriteLine(array3d[0,0,0]);
            int[,,,] array4d = {{{{1}}}};
            Console.WriteLine(array4d[0,0,0,0]);
            
            string namesList = "kaspar, martin, peeter, maarja, ott, helis";
            string[] ourNames = namesList.Split(", ");
            foreach(string n in ourNames){
                Console.WriteLine(n);
            }
            string dashed = string.Join("   ", ourNames);
            Console.WriteLine(dashed);
        }
    }
}
