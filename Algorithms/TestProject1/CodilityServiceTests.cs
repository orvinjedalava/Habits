using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class CodilityServiceTests
    {
        private CodilityService _service = new CodilityService();

        [Theory]
        [InlineData(3, 4, new int[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
        public void MinMaxDivision_Test(int k, int m, int[] input, int expectedResult)
        {
            int result = _service.MinMaxDivision(k, m, input);

            Assert.Equal(expectedResult, result);
        }
    }
}
