using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class SortServiceTests
    {
        SortService _service = new SortService();
        [Fact]
        public void BubbleSort_Test()
        {
            int[] input = { 8, 5, 7, 3, 1 };
            int[] expectedResult = { 1, 3, 5, 7, 8 };

            int[] result = _service.BubbleSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void InsertionSort_Test()
        {
            int[] input = { 8, 5, 7, 3, 1 };
            int[] expectedResult = { 1, 3, 5, 7, 8 };

            int[] result = _service.InsertionSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void SelectionSort_Test()
        {
            int[] input = { 8, 5, 7, 3, 1 };
            int[] expectedResult = { 1, 3, 5, 7, 8 };

            int[] result = _service.SelectionSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void QuickSort_Test()
        {
            int[] input = { 8, 5, 7, 3, 1, 2 };
            int[] expectedResult = { 1, 2, 3, 5, 7, 8 };

            int[] result = _service.QuickSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void CountingSort_Test()
        {
            int[] input = { 4, 2, 2, 6, 3, 3, 1, 6, 5, 2, 3 };
            int[] expectedResult = { 1, 2, 2, 2, 3, 3, 3, 4, 5, 6, 6 };

            int[] result = _service.CountingSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void RadixSort_Test()
        {
            int[] input = { 170, 45, 75, 90, 802, 24, 2, 66 };
            int[] expectedResult = { 2, 24, 45, 66, 75, 90, 170, 802 };

            int[] result = _service.RadixSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void MergeSort_Test()
        {
            int[] input = { 3, 7, 6, -10, 15, 23, 55, -13 };
            int[] expectedResult = { -13, -10, 3, 6, 7, 15, 23, 55 };

            int[] result = _service.MergeSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Fact]
        public void BinarySearch_Test()
        {
            int[] input = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 15;
            int expectedResult = 7;
            
            int result = _service.BinarySearch(input, target);

            Assert.Equal(expectedResult, result);
        }
    }
}
