using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int n = 1000;
            a = CreateArray(n);
            QuickSort(a, 0, a.Length - 1);
            PrintArray(a);
        }
        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i].ToString() + " ");
            Console.WriteLine("");
        }
        static int[] CreateArray(int n)
        {
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                a[i] = r.Next(10,10000);
            return a;
        }

        static void QuickSort(int[] a, int first, int last)
        {
            if (first >= last)
                return;
            int lastS1 = first, firstUnknown = first + 1;
            while (firstUnknown <= last)
            {
                if (a[firstUnknown] < a[first])
                {
                    Swap(ref a[firstUnknown], ref a[lastS1 + 1]);
                    lastS1++;
                    firstUnknown++;
                }
                else
                {
                    firstUnknown++;
                }
            }

            Swap(ref a[first], ref a[lastS1]);
            int pivotIndex = lastS1;
            QuickSort(a, first, pivotIndex - 1);
            QuickSort(a, pivotIndex + 1, last);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
