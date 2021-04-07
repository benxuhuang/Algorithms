using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(BinarySearch(arr,2));
        }

        static int BinarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length-1;

            while (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (target == arr[mid])
                    return mid;
            
                if (target > arr[mid])
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return -1;
        }
    }
}
