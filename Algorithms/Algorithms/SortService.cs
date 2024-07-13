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

        #region Radix Sort

        public int[] RadixSort(int[] input)
        {
            var map = new Dictionary<int, Queue<int>>();
            int exponent = 1;

            int maxValue = input[0];

            foreach (int item in input.ToList())
                maxValue = maxValue < item ?
                    item
                    : maxValue;

            while(maxValue / exponent > 0)
            {
                foreach(int item in input.ToList())
                {
                    int mapIndex = (item / exponent) % 10;
                    if (!map.ContainsKey(mapIndex))
                        map.Add(mapIndex, new Queue<int>());
                    map[mapIndex].Enqueue(item);
                }

                int inputIndex = 0;
                for (int i = 0; i <= 9; i++)
                {
                    if (map.ContainsKey(i))
                    {
                        while (map[i].Count > 0)
                        {
                            input[inputIndex] = map[i].Dequeue();
                            inputIndex++;
                        }
                    }
                }

                map.Clear();
                exponent *= 10;
            }

            return input;
        }

        #endregion

        #region MergeSort

        public int[] MergeSort(int[] input)
        {
            if (input.Length <= 1)
                return input;

            int mid = input.Length / 2;
            int[] leftArr = new int[mid];
            int[] rightArr = new int[input.Length - mid];

            Array.Copy(input, 0, leftArr, 0, leftArr.Length);
            Array.Copy(input, mid, rightArr, 0, rightArr.Length);

            int[] sortedLeftArr = MergeSort(leftArr);
            int[] sortedRightArr = MergeSort(rightArr);

            return Merge(sortedLeftArr, sortedRightArr);

        }

        private int[] Merge(int[] leftArr, int[] rightArr)
        {
            int[] result = new int[leftArr.Length + rightArr.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] < rightArr[j])
                {
                    result[k] = leftArr[i];
                    i++;
                }
                else
                {
                    result[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while(i < leftArr.Length)
            {
                result[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < rightArr.Length)
            {
                result[k] = rightArr[j];
                j++;
                k++;
            }

            return result;
        }

        #endregion

        #region BinarySearch

        public int BinarySearch(int[] input, int target)
        {
            int left = 0;
            int right = input.Length - 1;

            while(left < right)
            {
                int mid = (left + right) / 2;
                if (input[mid] == target)
                    return mid;

                if (input[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }


        #endregion
    }
}
