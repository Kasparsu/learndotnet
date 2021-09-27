using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //              false || true && false
            // bool answer = 10 < 1 || 2 > 1 &&  3 == 1;
            int num = 10;
            if(num != 10){  // != mitte võrdne == võrdne < väiksem > suurem <= väiksem võrdne >= suurem võrdne
                Console.WriteLine("väiksem");
            } else if(num == 10) {
                 Console.WriteLine("võrdne");
            } else {
                Console.WriteLine("suurem");
            }
            
            bool test = true;
            Console.WriteLine(!test);
            Console.WriteLine(num);
            
            num = 2;

            if(num == 1){
                Console.WriteLine("üks");
            } else if (num == 2 || num == 4) {
                Console.WriteLine("kaks v neli");
            } else if(num == 3) {
                Console.WriteLine("kolm");
            } else {
                Console.WriteLine("tundmatu");
            }

            switch(num) {
                case 1:
                    Console.WriteLine("üks");
                    break;
                case 4:
                case 2:
                    Console.WriteLine("kaks v neli");
                    break;
                case 3: 
                    Console.WriteLine("kolm");
                    break;
                default:
                    Console.WriteLine("tundmatu");
                    break;
            }
            
            // for(int i=0;i<100;i++) {
            //     if(i % 3 == 0) {
            //         Console.WriteLine(i);
            //     }
            // }
            // for(int i=0;i<100;i+=3) {
            //     Console.WriteLine(i);
            // }
            num = 1;
            for(int i=0;i<20;i++) {
                num*=2;
            }
            Console.WriteLine(num);

            for(int i=9;i>=0;i++) {
                Console.WriteLine(i);
            }
        }
    }
}
