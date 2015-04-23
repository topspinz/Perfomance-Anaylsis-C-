using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmn_Assignment
{
    internal class Program
    {

        //Use of wikipedia was used for creating the insertion sort and quick sort I simply converted the pesudo code appropriately

        private static void Main(string[] args)
        {
            const int N = 500000; //size of array
            const int MAXVALUE = 10*N;
            const int AVERAGEOVER = 1000000/N; //Number of iterations over averaeg
            var arraySlow = new int[N];
            var arrayFast = new int[N];
            Random random = new Random();
               
            for (int i = 0; i < AVERAGEOVER; i++)
            {

                //Fills Two Arrays Randomly
                for (int j = 0; j < N; j++)
                {

                    var k = random.Next(1, MAXVALUE);
                    arraySlow[j] = k;
                    arrayFast[j] = k;
                }

                FastSort(arrayFast, N);
                SlowSort(arraySlow, N);
            }

            //Converts n^2 Array to string
          //  string printArraySlow = string.Join(",", arrayFast.Select(x => x.ToString()).ToArray());


            //Converts nlogn Array to string
         //   string printArrayFast = string.Join(",", arraySlow.Select(x => x.ToString()).ToArray());
         

        //    Console.WriteLine("[" + printArraySlow + "]"); //Prints Array
        //    Console.WriteLine("[" + printArrayFast + "]"); //Prints Array
        }





        // Insertion Sort Algorithmn O(n^2)
        private static void SlowSort(int[] inputArray, int arraySize)
        {
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
        }

        //Quick Sort ologn Fast sort makes a recursive call to this
        private static void FastSort(int[] inputArray, int arraySize)
        {
            int left = 0;
            int right = arraySize - 1;
            QuickSort(inputArray, left, right);
        }


        public static void QuickSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int q = Partition(input, low, high);
                QuickSort(input, low, q - 1);
                QuickSort(input, q + 1, high);
            }
        }

        private static int Partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int temp;

            int i = low;
            for (int j = low; j < high; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[high] = input[i];
            input[i] = pivot;

            return i;
        }
    }
}



 



