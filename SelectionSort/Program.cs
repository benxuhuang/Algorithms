using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 1, 2, 6, 4 };
            Console.WriteLine("Sort befort");
            PrintArray(arr);
            SelectionSort(arr);
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

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }

                if (i != min)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }
    }
}
