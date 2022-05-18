using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Driver
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 78, 55, 45, 98, 13 };
            arr = QuickSort.SortArray(arr, 0, arr.Length - 1);

            foreach (var ele in arr)
            {
                Console.Write(ele + ",");
            }


        }
    }
}
