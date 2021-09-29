using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();              
            double num;
            int num2;
            for(int i = 0; i<10; i++){
                num = random.NextDouble()*10 + (20-10);
                Console.WriteLine(num);
                num2 = random.Next(10, 20); // 10 to 20
                Console.WriteLine(num2);
                num2 = random.Next(10); // 0 to 10
                Console.WriteLine(num2);
                num2 = random.Next(); // 0 to max int
                Console.WriteLine(num2);
            }
        }
    }
}
