using System;
using System.Linq;
using System.Collections.Generic;

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
