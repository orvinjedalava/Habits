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

        #region QuickSort
        public int[] QuickSort(int[] input)
        {
            QuickSort(input, 0, input.Length - 1);

            return input;
        }

        private void QuickSort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(input, low, high);
                QuickSort(input, low, pivotIndex - 1);
                QuickSort(input, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;
            int temp;

            for (int j = low; j < high; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }

            temp = input[i + 1];
            input[i + 1] = input[high];
            input[high] = temp;
            return i + 1;
        }

        #endregion

        #region CountingSort

        public int[] CountingSort(int[] input)
        {
            int maxValue = input[0];

            foreach (int item in input.ToList())
                maxValue = maxValue < item ?
                    item
                    : maxValue;

            int[] countResult = new int[maxValue + 1];

            foreach(int item in input.ToList())
            {
                countResult[item]++;
            }

            int index = 0;
            for(int i = 0; i <= maxValue; i++)
            {
                while (countResult[i] > 0)
                {
                    input[index] = i;
                    index++;
                    countResult[i]--;
                }
            }

            return input;
        }

        #endregion
    }
}
