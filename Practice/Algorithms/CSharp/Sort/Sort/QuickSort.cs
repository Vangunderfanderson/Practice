using System;

namespace Sort
{
    /// <summary>
    ///     Quicksort sorts a list of comparable elements
    ///     Average time complexity: O(n log n)
    ///     Worst time complexity: O(n^2)
    /// </summary>    
    public class QuickSort<T> : ISorter<T> where T : IComparable<T>
    {
        public string Name => "QuickSort";

        public T[] Sort(T[] array)
        {
            var arrayCopy = new T[array.Length];
            Array.Copy(array, 0, arrayCopy, 0, array.Length);
            QuickSortRecursive(ref arrayCopy, 0, array.Length - 1);
            return arrayCopy;
        }

        private void QuickSortRecursive(ref T[] array, int start, int end)
        {
            if (start >= end)
                return;

            var i = Partition(ref array, start, end);
            QuickSortRecursive(ref array, start, i);
            QuickSortRecursive(ref array, i + 1, end);
        }

        /// <summary>
        ///     Chooses a pivot and ensures that 
        ///     - All items to the left of the pivot are smaller than it.
        ///     - All items to the right of the pivot are larger than it.
        ///     Then returns the position of the pivot
        /// </summary>        
        private int Partition(ref T[] array, int start, int end)
        {
            var pivotPosition = (start + end) / 2;
            var pivot = array[pivotPosition];
            int i = start, j = end;
            while (i < j)
            { 
                if (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                    continue;
                }

                if (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                    continue;
                }
                Swap(ref array, i, j);
                i++;
                j--;
            }

            return i;
        }

        private void Swap(ref T[] array, int posA, int posB)
        {
            var temp = array[posA];
            array[posA] = array[posB];
            array[posB] = temp;
        }
    }
}
