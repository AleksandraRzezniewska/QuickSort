using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 2, 1, 5, 3, 4 };

            Quick_Sort(arr, 0, arr.Length - 1);

            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }

        public static void Quick_Sort(int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2];
            int i = left;
            int j = right;

            while (i < j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }

                if (left < j)
                {
                    Quick_Sort(array, left, j);
                }

                if (i < right)
                {
                    Quick_Sort(array, i, right);
                }
            }
        }
    }
}
