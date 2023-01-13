using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Problem_7_8
{
    internal class Sorter<T> where T : IComparable<T>, IEquatable<T>
    {
        public static MyList<T> QuickSort(MyList<T> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
                return array;

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private static int GetPivotIndex(MyList<T> array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i].CompareTo(array[maxIndex]) < 0)
                {
                    pivot++;
                    T tmp = array[pivot];
                    array[pivot] = array[i];
                    array[pivot] = tmp;
                }
            }

            pivot++;
            T tmp2 = array[pivot];
            array[pivot] = array[maxIndex];
            array[pivot] = tmp2;

            return pivot;
        }

        //private static void Swap(ref T leftItem, ref T rightItem)
        //{
        //    T temp = leftItem;

        //    leftItem = rightItem;

        //    rightItem = temp;
        //}
    }
}
