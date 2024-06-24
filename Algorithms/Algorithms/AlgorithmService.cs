using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class AlgorithmService
    {
        public string ReverseString(string input)
        {
            char[] result = input.ToCharArray();
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                result[i] = input[j];
                result[j] = input[i];
            }
            return new string(result);
        }

        public bool IsPalindrome(string input)
        {
            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
            {
                if (input[i] != input[j])
                    return false;
                continue;
            }

            return true;
        }

        public string ReverseWordOrder(string input)
        {
            int i = 0;
            StringBuilder result = new StringBuilder();

            int start = input.Length - 1;
            int end = input.Length - 1;

            while (start > 0)
            {
                if (input[start] == ' ')
                {
                    i = start + 1;
                    while (i <= end)
                    {
                        result.Append(input[i]);
                        i++;
                    }
                    result.Append(' ');
                    end = start - 1;
                }
                start--;

            }

            i = 0;
            while (i <= end)
            {
                result.Append(input[i]);
                i++;
            }

            return result.ToString().Trim();
        }

        public string ReverseEachWord(string input)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder word;
            int i = 0;
            int start = 0;
            int end = 0;

            while (end < input.Length)
            {
                if (input[end] == ' ')
                {
                    word = new StringBuilder();
                    while (start < end)
                    {
                        word.Append(input[start]);
                        start++;
                    }
                    result.Append(ReverseString(word.ToString())).Append(' ');
                    start++;
                }
                end++;
            }

            word = new StringBuilder();
            while (start < input.Length)
            {
                word.Append(input[start]);
                start++;
            }
            result.Append(ReverseString(word.ToString()));

            return result.ToString().Trim();
        }

        public Dictionary<char, int> CountCharacterOccurence(string input)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!result.ContainsKey(input[i]))
                        result.Add(input[i], 0);

                    result[input[i]]++;
                }
            }

            return result;
        }

        public bool IsPrimeNumber(int number)
        {
            if (number == 1 || number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        #region Not Implemented

        public int[] BubbleSort(int[] nums)
        {
            int[] staging = new int[nums.Length];
            nums.CopyTo(staging, 0);

            int[] result = new int[nums.Length];

            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                int? holdNumber = null;
                for (int i = 0; i < staging.Length; i++)
                {
                    if (!holdNumber.HasValue)
                        holdNumber = staging[i];

                    if (i <= staging.Length - 2 && holdNumber > staging[i + 1])
                    {
                        result[i] = staging[i + 1];
                        sorted = false;
                    }
                    else
                    {
                        result[i] = holdNumber.Value;
                        holdNumber = null;
                    }
                }
                result.CopyTo(staging, 0);
            }

            return result;
        }

        public int[] MergeSort(int[] input)
        {
            List<int[]> dividedArrays = Divide(input);

            int[] result = Merge(dividedArrays);

            return result;
        }

        public int[] Merge(List<int[]> dividedArrays)
        {
            if (dividedArrays.Count == 1)
                return dividedArrays[0];

            List<int[]> mergedArrays = new List<int[]>();

            for (int i = 0; i < dividedArrays.Count; i += 2)
            {
                int[] leftInput = dividedArrays[i];
                if (i + 1 < dividedArrays.Count)
                {
                    int[] rightInput = dividedArrays[i + 1];
                    mergedArrays.Add(Merge(leftInput, rightInput));
                }
                else
                {
                    mergedArrays.Add(leftInput);
                }
            }

            return Merge(mergedArrays);

        }

        public List<int[]> Divide(int[] input)
        {
            List<int[]> dividedArrays = new List<int[]>();
            if (input.Length == 1)
            {
                dividedArrays.Add(input);
                return dividedArrays;
            }

            int start = 0;
            int end = input.Length - 1;
            int middle = end / 2;

            int leftInputLength = middle + 1;
            int rightInputLength = end - middle;

            int[] leftInput = new int[leftInputLength];
            int[] rightInput = new int[rightInputLength];

            Array.Copy(input, start, leftInput, 0, leftInputLength);
            Array.Copy(input, middle + 1, rightInput, 0, rightInputLength);

            dividedArrays.AddRange(Divide(leftInput));
            dividedArrays.AddRange(Divide(rightInput));

            return dividedArrays;
        }

        public int[] Merge(int[] leftInput, int[] rightInput)
        {
            return BubbleSort(leftInput.Concat(rightInput).ToArray());
        }

        #endregion NotImplemented
    }
}
