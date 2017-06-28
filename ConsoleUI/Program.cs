using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.IntArrSorting;

namespace ConsoleUI
{
  
    class Program
    {
        static void ShowArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] array0 = { 2, 5, 7, 3, 6, 9, 5 };
            int[] array1 = { 4, 1, 2, 3 };
            int[] array2 = { };
                
            int[] array = array0;

            
            Console.WriteLine("Input array: ");
            ShowArray(array);

            QuickSort(array);
            //MergeSort(array);
         
            Console.WriteLine("Output array: ");
            ShowArray(array);
        }
    }
}
