using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortLibrary;

namespace SortLibraryTest
{
    [TestClass]
    public class ArraySortTest
    {
        private readonly int[] _fullyUnsortedEvenLengthArray = new int[] { 7, 6, 5, 4, 3, 2, 1, 0 };
        private readonly int[] _sortedEvenLengthArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
        private readonly int[] _unsortedEvenLengthArray = new int[] { 0, 3, 6, 1, 7, 5, 2, 4 };

        private readonly int[] _fullyUnsortedOddLengthArray = new int[] { 7, 6, 5, 4, 3, 2, 1 };        
        private readonly int[] _sortedOddLengthArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        private readonly int[] _unsortedOddLengthArray = new int[] { 1, 4, 5, 2, 3, 7, 6 };

        [TestMethod]
        public void SelectionSortTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.SelectionSort((int[])this._fullyUnsortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.SelectionSort((int[])this._sortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.SelectionSort((int[])this._unsortedEvenLengthArray.Clone())));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.SelectionSort((int[])this._fullyUnsortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.SelectionSort((int[])this._sortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.SelectionSort((int[])this._unsortedOddLengthArray.Clone())));
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSort((int[])this._fullyUnsortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSort((int[])this._sortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSort((int[])this._unsortedEvenLengthArray.Clone())));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSort((int[])this._fullyUnsortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSort((int[])this._sortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSort((int[])this._unsortedOddLengthArray.Clone())));
        }

        [TestMethod]
        public void BubbleSortRecursiveTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSortRecursive((int[])this._fullyUnsortedEvenLengthArray.Clone(), this._fullyUnsortedEvenLengthArray.Length)));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSortRecursive((int[])this._sortedEvenLengthArray.Clone(), this._sortedEvenLengthArray.Length)));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSortRecursive((int[])this._unsortedEvenLengthArray.Clone(), this._unsortedEvenLengthArray.Length)));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSortRecursive((int[])this._fullyUnsortedOddLengthArray.Clone(), this._fullyUnsortedOddLengthArray.Length)));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSortRecursive((int[])this._sortedOddLengthArray.Clone(), this._sortedOddLengthArray.Length)));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.BubbleSortRecursive((int[])this._unsortedOddLengthArray.Clone(), this._unsortedOddLengthArray.Length)));
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.InsertionSort((int[])this._fullyUnsortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.InsertionSort((int[])this._sortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.InsertionSort((int[])this._unsortedEvenLengthArray.Clone())));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.InsertionSort((int[])this._fullyUnsortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.InsertionSort((int[])this._sortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.InsertionSort((int[])this._unsortedOddLengthArray.Clone())));
        }

        [TestMethod]
        public void MergeSortTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.MergeSort((int[])this._fullyUnsortedEvenLengthArray.Clone(), 0, this._fullyUnsortedEvenLengthArray.Length - 1)));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.MergeSort((int[])this._sortedEvenLengthArray.Clone(), 0, this._sortedEvenLengthArray.Length - 1)));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.MergeSort((int[])this._unsortedEvenLengthArray.Clone(), 0, this._unsortedEvenLengthArray.Length - 1)));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.MergeSort((int[])this._fullyUnsortedOddLengthArray.Clone(), 0, this._fullyUnsortedOddLengthArray.Length - 1)));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.MergeSort((int[])this._sortedOddLengthArray.Clone(), 0, this._sortedOddLengthArray.Length - 1)));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.MergeSort((int[])this._unsortedOddLengthArray.Clone(), 0, this._unsortedOddLengthArray.Length - 1)));
        }

        [TestMethod]
        public void QuickSortTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.QuickSort((int[])this._fullyUnsortedEvenLengthArray.Clone(), 0, this._fullyUnsortedEvenLengthArray.Length - 1)));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.QuickSort((int[])this._sortedEvenLengthArray.Clone(), 0, this._sortedEvenLengthArray.Length - 1)));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.QuickSort((int[])this._unsortedEvenLengthArray.Clone(), 0, this._unsortedEvenLengthArray.Length - 1)));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.QuickSort((int[])this._fullyUnsortedOddLengthArray.Clone(), 0, this._fullyUnsortedOddLengthArray.Length - 1)));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.QuickSort((int[])this._sortedOddLengthArray.Clone(), 0, this._sortedOddLengthArray.Length - 1)));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.QuickSort((int[])this._unsortedOddLengthArray.Clone(), 0, this._unsortedOddLengthArray.Length - 1)));
        }

        [TestMethod]
        public void RadixSortTest()
        {
            var sorter = new ArraySort();
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.RadixSort((int[])this._fullyUnsortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.RadixSort((int[])this._sortedEvenLengthArray.Clone())));
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.RadixSort((int[])this._unsortedEvenLengthArray.Clone())));

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.RadixSort((int[])this._fullyUnsortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.RadixSort((int[])this._sortedOddLengthArray.Clone())));
            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7", string.Join(", ", sorter.RadixSort((int[])this._unsortedOddLengthArray.Clone())));
        }
    }
}
