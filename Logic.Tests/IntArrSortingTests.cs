using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Logic.Tests
{

    [TestFixture]
    public class IntArrSortingTests
    {
        #region QuickSortTests

        [TestCase(new int[] { 1, 5, 6, 8, 1, 2 }, new int[] { 1, 1, 2, 5, 6, 8 })]
        [TestCase(new int[] { 0, 1, 0, 2, 3 }, new int[] { 0, 0, 1, 2, 3 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [Category("QuickSortTests")]
        public void QuickSort_GoodArray_SortsArray(int[] arr, int[] expectedRes)
        {
            IntArrSorting.QuickSort(arr);
            bool result = arr.SequenceEqual<int>(expectedRes);
            Assert.True(result);
        }

        [Test]
        [Category("QuickSortTests")]
        public void QuickSort_NullArray_ReturnsException()
        {
            var ex = Assert.Catch<ArgumentNullException>(() => IntArrSorting.QuickSort(null));
            StringAssert.Contains("Value cannot be null.", ex.Message);
        }

        [Test]
        [Category("QuickSortTests")]
        public void QuickSort_EmptyArray_ReturnsException()
        {
            var ex = Assert.Catch<ArgumentException>(() =>
            IntArrSorting.QuickSort(new int[] { }));
            StringAssert.Contains("Value does not fall within the expected range.", ex.Message);
        }

        [TestCase(new int[] { 1, 4, 2 }, -1, 0)]
        [TestCase(new int[] { 1, 4, 2 }, 0, 3)]
        [TestCase(new int[] { 1, 4, 2 }, 2, 1)]
        [Category("QuickSortTests")]
        public void QuickSort_IncorrectBoundMembers_ReturnsException(int[] arr, int l, int r)
        {
            var ex = Assert.Catch<ArgumentException>(() =>
            IntArrSorting.QuickSort(arr, l, r));
            StringAssert.Contains("Value does not fall within the expected range.", ex.Message);
        }

        #endregion


        #region MergeSortTests

        [TestCase(new int[] { 1, 5, 6, 8, 1, 2 }, new int[] { 1, 1, 2, 5, 6, 8 })]
        [TestCase(new int[] { 0, 1, 0, 2, 3 }, new int[] { 0, 0, 1, 2, 3 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [Category("MergeSortTests")]
        public void MergeSort_GoodArray_SortsArray(int[] arr, int[] expectedRes)
        {
            IntArrSorting.MergeSort(arr);
            bool result = arr.SequenceEqual<int>(expectedRes);
            Assert.True(result);
        }

        [Test]
        [Category("MergeSortTests")]
        public void MergeSort_NullArray_ReturnsException()
        {
            var ex = Assert.Catch<ArgumentNullException>(() => IntArrSorting.MergeSort(null));
            StringAssert.Contains("Value cannot be null.", ex.Message);
        }

        [Test]
        [Category("MergeSortTests")]
        public void MergeSort_EmptyArray_ReturnsException()
        {
            var ex = Assert.Catch<ArgumentException>(() =>
            IntArrSorting.MergeSort(new int[] { }));
            StringAssert.Contains("Value does not fall within the expected range.", ex.Message);
        }

        #endregion

    }


}
