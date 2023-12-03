using System;

namespace AlgorithmStudy
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            TestQuickSort();

            while (true) ;
        }

        private static void TestQuickSort()
        {
            int[] arr = new int[10];

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            new QuickSort().Sort(ref arr, 0, arr.Length - 1);

            Console.WriteLine("========================");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        private static void TestMergeSort()
        {
            int[] arr = new int[10];

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            new MergeSort().Sort(ref arr, 0, arr.Length - 1);

            Console.WriteLine("========================");

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
