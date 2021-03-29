using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 8, 2, 1, 4 };

            Console.WriteLine(BubbleSort(arr));
        }

        static int[] BubbleSort(int[] arr)
        {
            int arrLength = arr.Length;

            //判斷是否有沒有發生交換
            bool flag = false;

            while (arrLength > 1)
            {
                arrLength--;

                for (int i = 0; i < arrLength; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        var temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        flag = true;
                    }
                }

                //當第一個迴圈沒有發生交換則代表 arr 內的元素為由小排到大，故不需要再進行排序。
                if (flag == false) break;
            }

            return arr;
        }
    }
}
