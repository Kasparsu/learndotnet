using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Sisesta esimene number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta teine number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta operatsioon (liida, lahuta, korruta, jaga):");
                string operation = Console.ReadLine();
                int answer;
                switch(operation) {
                    case "liida": 
                        answer = num1+num2;
                        break;
                    case "lahuta": 
                        answer = num1-num2;
                        break;
                    case "korruta": 
                        answer = num1*num2;
                        break;
                    case "jaga": 
                        answer = num1/num2;
                        break;
                    default:
                        throw(new Exception());
                }
                Console.WriteLine("Vastus on:" + answer);
            } catch {
                Console.WriteLine("Vale sisend!");
            }

        }
    }
}
