using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            for(var i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for(var j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1] = temp;
                        swapped = true;
                    }

                }
                if (swapped == false)
                    break;

            }


            return arr;
        }

    }
}
