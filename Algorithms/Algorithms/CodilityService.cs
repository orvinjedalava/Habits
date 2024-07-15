using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CodilityService
    {
        #region MinMaxDivision

        /// <summary>
        /// Use Binary Algorithm
        /// https://www.youtube.com/watch?v=cAQAb_DI1J0&list=PLTMybUaeagJbTAelBd-pGBuAngpPtnw8b&index=38
        /// </summary>
        /// <param name="k"></param>
        /// <param name="m"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>

        public int MinMaxDivision(int k, int m, int[] input)
        {
            // the possible least "largest sum" array
            int min = 0;
            // the sum of all elements in the array is the largest "largest sum" array.
            int max = 0;

            for (int i = 0; i < input.Length; i++)
            {
                max += input[i];
                min = Math.Max(min, input[i]);
            }

            // the best fit value for k blocks
            int bestAnswer = max;

            while (min <= max)
            {
                // get the mid point
                int mid = (min + max) / 2;

                int blocks = CheckHowManyBlocksFor(input, mid);

                if (blocks > k) // guess value provided in CheckHowManyBlocksFor() is smaller than what we are looking for.
                {
                    min = mid + 1;
                }
                // guess value provided in CheckHowManyBlocksFor() resulted in valid number of blocks.
                // we can fill up the remaining blocks with empty arrays ( [] ). Continue adjusting 
                else
                {
                    max = mid - 1;
                    if (mid < bestAnswer)
                    {
                        bestAnswer = mid;
                    }
                }
            }

            return bestAnswer;

        }

        /// <summary>
        /// Gives the number of maximum blocks that can be formed from an array for a given guess value.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        private int CheckHowManyBlocksFor(int[] input, int guess)
        {
            // the iteration start will count as first block (1)
            int blocks = 1;
            int blockSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                blockSum += input[i];
                // if adding current element overflows the sum, add a block and reset the sum to the current element
                if (blockSum > guess)
                {
                    blocks++;
                    blockSum = input[i];
                }
            }

            return blocks;
        }

        #endregion
    }
}
