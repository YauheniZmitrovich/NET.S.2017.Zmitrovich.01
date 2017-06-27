using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// The class helps to sort an array of type int[] in several ways.
    /// </summary>
    public static class IntArrSorting
    {
        /// <summary>
        /// Sorts int elements in an entire one-dimensional array by Hoar's alghorithm.
        /// </summary>
        /// <param name="arr">
        /// The one-dimensional int array to sort.
        /// </param>
        /// <param name="left">
        /// Left bound index of the selected part of the array.
        /// </param>
        /// <param name="right">
        /// Left bound index of the selected part of the array.
        /// </param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (arr.Length == 0)
                return;

            int pivot = arr[left + (right - left) / 2];
            int i = left;
            int j = right;

            while (i <= j)
            {
                for (; arr[i] < pivot; i++) ;
                for (; arr[j] > pivot; j--) ;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (i < right)
                QuickSort(arr, i, right);
            if (j > left)
                QuickSort(arr, left, j);
        }


        /// <summary>
        /// Sorts int elements in an entire one-dimensional array by merger.
        /// </summary>
        /// <param name="arr">
        /// The one-dimensional int array to sort.
        /// </param>
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int middle = arr.Length / 2;

            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            int i;
            for (i = 0; i < middle; i++)
            {
                left[i] = arr[i];
            }
            for (i = 0; i < right.Length; i++)
            {
                right[i] = arr[i + middle];
            }

            left = MergeSort(left);
            right = MergeSort(right);

            int[] result = Merge(left, right);

            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {

            int[] result = new int[left.Length + right.Length];
            int l = 0;
            int r = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (r >= right.Length)
                {
                    result[i] = left[l];
                    l++;
                }
                else if (l < left.Length && left[l] < right[r])
                {
                    result[i] = left[l];
                    l++;
                }
                else
                {
                    result[i] = right[r];
                    r++;
                }
            }
            return result;
        }

    }
}
