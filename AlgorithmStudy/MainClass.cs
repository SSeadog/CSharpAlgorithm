using System;

namespace AlgorithmStudy
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            TestThreeMatch();

            Console.WriteLine("끝");
            while (true) ;
        }

        private static void TestThreeMatch()
        {
            new ThreeMatch().Run();
        }

        private static void TestSelectionSort()
        {
            int[] arr = new int[100];

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);

            new SelectionSort().Sort(ref arr);

            //Console.WriteLine("========================");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i - 1] > arr[i])
                    Console.WriteLine("정렬에 맞지 않음");
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("========================");
        }

        private static void TestBubbleSort()
        {
            int[] arr = new int[100];

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);

            new BubbleSort().Sort(ref arr);

            //Console.WriteLine("========================");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i - 1] > arr[i])
                    Console.WriteLine("정렬에 맞지 않음");
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("========================");
        }

        private static void TestInsertionSort()
        {
            int[] arr = new int[100];

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);

            new InsertionSort().Sort(ref arr);

            //Console.WriteLine("========================");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i - 1] > arr[i])
                    Console.WriteLine("정렬에 맞지 않음");
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("========================");
        }
        
        private static void TestQuickSort()
        {
            int[] arr = new int[38];

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 10);

            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            new QuickSort().Sort(ref arr, 0, arr.Length - 1);

            //Console.WriteLine("========================");

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i - 1] > arr[i])
                    Console.WriteLine("정렬에 맞지 않음");
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("========================");
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
