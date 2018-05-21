using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary
{
    public class ArraySort
    {
        public ArraySort()
        {
        }
        
        private void Swap(int[] data, int indexOne, int indexTwo)
        {
            int temp = data[indexOne];
            data[indexOne] = data[indexTwo];
            data[indexTwo] = temp;
        }

        /// <summary>
        /// Sorts by finding the smallest item in the array and swapping it to the beginning of the unsorted portion 
        /// of the list. O(n^2)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int[] SelectionSort(int[] data)
        {            
            for (int i = 0; i < data.Length - 1; i++)
            {
                // Find the minumum int the current unsorted portion of the array
                int minValueIndex = i;
                for (int j = i; j < data.Length; j++)
                {                    
                    if (data[j] < data[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }
                this.Swap(data, i, minValueIndex);
            }

            return data;
        }

        /// <summary>
        /// Sorts by swapping adjacent elements until the array is sorted.
        /// Keeps going through array until it is all sorted.
        /// Largest item bubbles to top. O(n^2)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int[] BubbleSort(int[] data)
        {
            bool hasSwaped;
            int iterations = data.Length - 1;
            do
            {
                hasSwaped = false;
                for (int i = 0; i < iterations; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        this.Swap(data, i, i + 1);
                        hasSwaped = true;
                    }
                }
                --iterations;
            } while (hasSwaped);

            return data;
        }

        /// <summary>
        /// Sorts by swapping adjacent elements until the array is sorted.
        /// Keeps going through array until it is all sorted.
        /// Largest item bubbles to top. O(n^2)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int[] BubbleSortRecursive(int[] data, int length)
        {
            bool hasSwaped = false;            
            for (int i = 0; i < length - 1; i++)
            {
                if (data[i] > data[i + 1])
                {
                    this.Swap(data, i, i + 1);
                    hasSwaped = true;
                }
            }
            if (hasSwaped)
            {
                return BubbleSortRecursive(data, length - 1);
            }
            else
            {
                return data;
            }
        }

        /// <summary>
        /// Start sorting from i = 1 and take item at [i] and place it into the already sorted protion of the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int[] InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int currentItemValue = data[i];
                if (currentItemValue < data[i - 1])
                {                    
                    int j = i - 1;
                    while (j >= 0 && currentItemValue < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                    }
                    data[j+1] = currentItemValue;
                }
            }

            return data;
        }

        public int[] MergeSort(int[] data, int left, int right)
        {
            int midPoint = (left + right) / 2;
            if (left != right)
            {
                MergeSort(data, left, midPoint);
                MergeSort(data, midPoint + 1, right);
            }

            int i = 0;
            int j = 0;
            int k = left;
            int leftSize = midPoint - left + 1;
            int rightSize = right - midPoint;

            int[] tempLeftArray = new int[leftSize];
            int[] tempRightArray = new int[rightSize];

            for (i = 0; i < leftSize; i++)
            {
                tempLeftArray[i] = data[left + i];
            }
            for (i = 0; i < rightSize; i++)
            {
                tempRightArray[i] = data[midPoint + 1 + i];
            }

            i = 0;
            j = 0;            
            while (i < leftSize && j < rightSize)
            {
                if (tempLeftArray[i] < tempRightArray[j])
                {
                    data[k] = tempLeftArray[i];
                    ++i;
                }
                else if (tempLeftArray[i] >= tempRightArray[j])
                {
                    data[k] = tempRightArray[j];
                    ++j;
                }
                ++k;
            }

            for (; i < leftSize; i++, k++)
            {
                data[k] = tempLeftArray[i];
            }

            for (; j < rightSize; j++, k++)
            {
                data[k] = tempRightArray[j];
            }

            return data;
        }
    }
}
