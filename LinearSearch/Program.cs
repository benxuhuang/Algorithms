using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4,1,7,1,7,5,1,8,4,2 };
            Console.WriteLine(LinearSearch(arr,8));
        }

        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
    }
}
