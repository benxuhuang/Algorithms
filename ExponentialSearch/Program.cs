using System;

namespace ExponentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 9, 30, 32, 38, 47, 61, 69, 79, 81 };
            Console.WriteLine(ExponentialSearch(arr, 47));
        }

        public static int ExponentialSearch(int[] array, int targetElement)
        {
            int length = array.Length;

            if (length == 0) return -1;
            if (targetElement == array[0]) return 0;

            int two = 1;

            while (two < length)
            {
                if (targetElement == array[two])
                {
                    return two;
                }
                else if (targetElement < array[two])
                {
                    //右位移一個位元等同於「除以2」
                    return BinarySearch(array, targetElement, (two >> 1) + 1, two - 1);
                }

                //左位移一個位元等同於「乘以2」
                two <<= 1;
            }

            return BinarySearch(array, targetElement, (two >> 1) + 1, length - 1);
        }

        private static int BinarySearch(int[] array, int targetElement, int start, int end)
        {
            while (end >= start)
            {
                int mid = start + (end - start) / 2;

                if (targetElement == array[mid])
                    return mid;

                if (targetElement > array[mid])
                    start = mid + 1;
                else
                    end = mid - 1;
            }

            return -1;
        }
    }
}
