using System;


namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations op = new ArrayOperations();
            int[] array = new int[5] { 6, 4, 8, 9, 3 };

            op.ShowArray(array);

            op.BubbleSort(ref array);

            Console.WriteLine("Ordered array:");
            op.ShowArray(array);
        }
    }
}
