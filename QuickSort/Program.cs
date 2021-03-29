using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 4, 1, 6, 7, 3, 8, 2, 5 };
            PrintArr(arr);
            QuickSort(arr, 0, arr.Length - 1);
            PrintArr(arr);
        }

        static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int Partition(int[] arr, int front, int end)
        {
            int pivot = arr[end];
            int i = front - 1;
            for (int j = front; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            i++;
            Swap(arr, i, end);
            return i;
        }
        
        static void QuickSort(int[] arr, int front, int end)
        {
            if (front < end)
            {
                int pivot = Partition(arr, front, end);
                QuickSort(arr, front, pivot - 1);
                QuickSort(arr, pivot + 1, end);
            }
        }

        static void PrintArr(int[] arr)
        {
            string result = String.Empty;
            foreach (var item in arr)
                result += $"{item} ";
            Console.WriteLine(result);
        }
    }
}
