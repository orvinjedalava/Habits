using Algorithms;
using System.Runtime.CompilerServices;

namespace TestProject1
{
    public class AlgorithmServiceTests
    {
        private AlgorithmService _service = new AlgorithmService();
        [Theory]
        [InlineData("hello world", "dlrow olleh")]
        [InlineData("hire me", "em erih")]
        public void ReverseString_Tests(string input, string expectedResult)
        {
            string result = _service.ReverseString(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("madam", true)]
        [InlineData("step on no pets", true)]
        [InlineData("book", false)]
        public void IsPalindrome_Tests(string input, bool expectedResult)
        {
            bool result = _service.IsPalindrome(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("Welcome to CSharp", "CSharp to Welcome")]
        [InlineData("I am hungry", "hungry am I")]
        public void ReverseWordOrder_Tests(string input, string expectedResult)
        {
            string result = _service.ReverseWordOrder(input);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("Welcome to CSharp", "emocleW ot prahSC")]
        [InlineData("Hello team", "olleH maet")]
        public void ReverseEachWord_Tests(string input, string expectedResult)
        {
            string result = _service.ReverseEachWord(input);
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void CountCharacterOccurence_Tests()
        {
            string input = "Hello world";
            Dictionary<char, int> expectedResult = new()
            {
                {'H',1},{'e',1},{'l',3 },{'o',2},{'w',1},{'r',1 },{'d',1}
            };

            Dictionary<char, int> result = _service.CountCharacterOccurence(input);
            foreach (var item in expectedResult)
            {
                Assert.Equal(item.Value, result[item.Key]);
            }
        }
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(37, true)]
        [InlineData(100, false)]
        public void IsPrimeNumber_Tests(int input, bool expectedResult)
        {
            bool result = _service.IsPrimeNumber(input);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void BubbleSort_Test_1()
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
        public void MergeSort_Test()
        {
            int[] input = { 8, 5, 7, 3, 1 };
            int[] expectedResult = { 1, 3, 5, 7, 8 };

            int[] result = _service.MergeSort(input);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}