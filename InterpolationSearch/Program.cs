using System;
namespace InterpolationSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 9, 30, 32, 38, 47, 61, 69, 79, 81 };
            var result = InterpolationSearch(arr, 9);
            Console.WriteLine(result);
        }

        public static int InterpolationSearch(int[] array, int targetElement)
        {

            int start = 0;
            int end = array.Length - 1;

            while (end >= start)
            {
                int x = (targetElement - array[start]) * (end - start) / (array[end] - array[start]) + start;

                if (x > end || x < start)
                {
                    break;
                }

                if (targetElement == array[x])
                {
                    return x;
                }
                else if (targetElement > array[x])
                {
                    start = x + 1;
                }
                else
                {
                    end = x - 1;
                }
            }

            return -1;
        }
    }
}
