using System;

namespace SortAlgorithm
{
    public class QuickSort
    {
        public static void Client()
        {
            var list = new int[10];

            for (int i = 0; i < list.Length; i++)
            {
                Random rnd = new Random();
                var val = rnd.Next(10, 100);
                list[i] = val;
            }

            Sort(list, 0, list.Length - 1);

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }           
        }
        
        public static void Sort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = array[(left + right) / 2];
            int index = partition(array, left, right, pivot);
            Sort(array, left, index - 1);
            Sort(array, index, right);
        }

        public static int partition (int[] array, int left, int right, int pivot)
        {
            while(left <= right)
            {
                while(array[left] < pivot)
                {
                    left++;
                }

                while(array[right] > pivot)
                {
                    right--;
                }

                if(left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

    }
    
}
