using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandy1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 7, 8, 15, 21, 50, 66 };
            Console.WriteLine("enter a key number");
            int key = int.Parse(Console.ReadLine());
            int index = RecursionBinarySearsh(array, key, 0, array.Length - 1);
            Console.WriteLine("index of " + key + "=" + index);
            ///
            int[] arr = { 4, 5, 7, 9, 15, 20, 50, 66 };
            Console.WriteLine("enter a key number");
            int keyy = int.Parse(Console.ReadLine());
            int indexx = Binary(arr, keyy);
            Console.WriteLine("index of " + keyy + "=" + indexx);
        }

        //البحث الثنائي عودية
        static int RecursionBinarySearsh(int[] array, int key, int start, int end)
        {


            int mid = (start + end) / 2;
            if (key == array[mid])
                return (mid + 1);
            if (key > array[mid])
                return RecursionBinarySearsh(array, key, mid + 1, start);

            else if (key > array[mid])
                return RecursionBinarySearsh(array, key, end, mid - 1);

            else return -1;
        }

        //البحث الثنائي تكراري 
        static int Binary(int[] arr, int key)
        {
            int end = 0;
            int start = arr.Length - 1;
            while (end <= start)
            {
                int mid = (end + start) / 2;
                if (key == arr[mid])
                    return (mid + 1);
                if (key > arr[mid])
                    end = mid + 1;
                else start = mid - 1;

            }
            return -1;
        }
    }
}
