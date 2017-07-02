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

        #region QuickSort
        /// <summary>
        /// Sorts int elements in an entire one-dimensional array by Hoar's alghorithm.
        /// </summary>
        /// <param name="arr">
        /// The one-dimensional int array to sort.
        /// </param>
        public static void QuickSort(int[] arr)
        {
            CheckInputArray(arr);
            QuickSort(arr, 0, arr.Length - 1);
        }

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
            CheckInputArray(arr);
            CheckBounds(arr, left, right);

            if (arr.Length == 1)
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
        #endregion

        #region MergeSort
        /// <summary>
        /// Sorts int elements in an entire one-dimensional array by merger.
        /// </summary>
        /// <param name="arr">
        /// The one-dimensional int array to sort.
        /// </param>        
        public static void MergeSort(int[] arr)
        {
            CheckInputArray(arr);

            if (arr.Length == 1)
                return;

            int middle = arr.Length / 2;

            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];


            for (int i = 0; i < middle; i++)
            {
                left[i] = arr[i];
            }
            for (int i = 0; i < right.Length; i++)
            {
                right[i] = arr[i + middle];
            }

            MergeSort(left);
            MergeSort(right);

            int[] result = Merge(left, right);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = result[i];
            }
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
        #endregion

        #region CheckingMethods
        private static void CheckBounds(int[] arr, int l, int r)
        {
            bool flag1 = (l < 0 || r >= arr.Length);
            bool flag2 = l > r;

            if (flag1 || flag2)
                throw new ArgumentException();
        }

        private static void CheckInputArray(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            if (arr.Length == 0)
                throw new ArgumentException();
        }
        #endregion

    }
}
