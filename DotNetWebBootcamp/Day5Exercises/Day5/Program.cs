using System.Globalization;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OptimizedBubbleSort();
            Console.WriteLine("");

            OptimizedInsertionSort();
            Console.WriteLine("\n");

            Console.ReadKey();
        }

                //Add an extra variable swap, by which we can avoid loop iteration if/when values are sorted
        //It will reduce execution time
        public static void BubbleSort()
        {
            int[] arr = { 80, 11, 590, 771, 9, 770, 240, 9 };

            Console.Write("\nUnsorted Array: ");
            DisplayArray(arr);

            for (int write = 0; write < arr.Length; write++)
            {
                bool swapped = false;

                for (int sort = 0; sort < arr.Length - 1; sort++)
                    if (arr[sort] > arr[sort + 1])
                    {
                        (arr[sort], arr[sort + 1]) = (arr[sort + 1], arr[sort]);
                        swapped= true;
                    }
                if (swapped == false)
                    break;
            }

            Console.Write("\nBubble Sort: ");
            DisplayArray(arr);
        }

        //if-statement and flag variable are redundent 
        //Removing them will reduce time and space complexity
        public static void InsertionSort()
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int n = arr.Length, i, j, val;

            Console.Write("\nUnsorted Array: ");
            DisplayArray(arr);

            for (i = 1; i < n; i++)
            {
                val = arr[i];

                for (j = i - 1; j >= 0 && val < arr[j]; j--)
                    arr[j + 1] = arr[j];
                arr[j + 1] = val;
            }

            Console.Write("\nInsersion Sort: ");
            DisplayArray(arr);
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i + " ");
        }
    }
}
