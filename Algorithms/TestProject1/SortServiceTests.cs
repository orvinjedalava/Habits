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
            int[] input = { 8, 5, 7, 3, 1 };
            int[] expectedResult = { 1, 3, 5, 7, 8 };

            int[] result = _service.QuickSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
