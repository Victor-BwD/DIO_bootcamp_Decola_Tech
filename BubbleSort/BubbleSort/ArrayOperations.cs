using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    class ArrayOperations
    {
        public void BubbleSort(ref int[] array)
        {
            int aux = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        aux = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }

        public void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array);
            }
        }
    }
}
