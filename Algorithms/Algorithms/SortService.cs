using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SortService
    {
        public int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            return input;
        }

        public int[] InsertionSort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                int current = input[i];
                int j = i - 1;

                while (j > -1 && input[j] > current)
                {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = current;
            }

            return input;
        }

        public int[] SelectionSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int minIdx = i;

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[minIdx] > input[j])
                    {
                        minIdx = j;
                    }
                }
                if (minIdx != i)
                {
                    int temp = input[minIdx];
                    input[minIdx] = input[i];
                    input[i] = temp;
                }
            }
            return input;
        }

        public int[] QuickSort(int[] input)
        {
            return input;
        }
    }
}
