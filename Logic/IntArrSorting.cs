using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// The class helps to sort an array of type int[].
    /// </summary>
    public static class IntArrSorting
    {
        /// <summary>
        /// Sorts int elements in an entire one-dimensional array.
        /// </summary>
        /// <param name="arr">
        /// The one-dimensional int array to sort.
        /// </param>
        /// <param name="l">
        /// Left bound index of the selected part of the array.
        /// </param>
        /// <param name="r">
        /// Left bound index of the selected part of the array.
        /// </param>
        public static void QuickSort(int[] arr, int l, int r)
        {
            if (arr.Length == 0)
                return;

            int pivot = arr[l + (r - l) / 2];
            int i = l;
            int j = r;

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

            if (i < r)
                QuickSort(arr, i, r);
            if (j > l)
                QuickSort(arr, l, j);
        }

    }
}
