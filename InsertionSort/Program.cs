using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 1, 2, 6, 4 };
            Console.WriteLine("Sort befort");
            PrintArray(arr);
            InsertionSort(arr);
            Console.WriteLine("Sort after");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                result += $"{arr[i]} ";
            }
            Console.WriteLine(result);
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    //往前一個檢查直到索引為0才停止檢查大小
                    j--;
                }

                arr[j + 1] = key;
            }
        }
    }
}
