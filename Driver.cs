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
            arr = BubbleSort.Sort(arr);

            foreach (var ele in arr)
            {
                Console.Write(ele + ",");
            }


        }
    }
}
