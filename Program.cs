using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5,2,4,6,1,4,3};
            int[] result = insertSort(array);
            foreach(int num in result){
                Console.WriteLine(num);
            }
            char letter = '"';
            string words = "vvvaa";
            //words = System.String.Empty;
            Console.WriteLine(words.IndexOf('a'));
            Console.WriteLine(words.Substring(2,2));
            Console.WriteLine(words.Replace('v', 'b'));
            Console.WriteLine(words.Contains('b'));
            Console.WriteLine(words.Insert(2, "sss"));
            Console.WriteLine(words.Remove(2, 2));
            Console.WriteLine(words.Trim());
            
            Match value = Regex.Match(" ssss  aaaaa  ssdfafa ababa faf af ", "[ab]{5}");
            Console.WriteLine("matched:" + value.Value);

            MatchCollection values = Regex.Matches(" ssss  aaaaa ssdfafa ababa faf af ", "[ab]{5}");
            foreach(Match val in values){
                Console.WriteLine(val.Value);
            }
        }

        static int[] insertSort(int[] array) {
            for(int i = 0; i<array.Length; i++){
                int min = array[i];
                int minPos = i;
                for(int j = i; j<array.Length; j++){
                    if(array[j] < min){
                        min = array[j];
                        minPos = j;
                    }
                }
                int temp = array[i];
                array[i] = min;
                array[minPos] = temp;
            }
            return array;
        }
    }
}
