using System;
using Xunit;
using Program;

namespace TestProject1
{
    public class UnitTest1
    {
        // test challenge 1
        [Fact]
        public void TestProduct()
        {
            String[] arr = { "1", "2", "3" };
            String[] arr1 = { "1", "2", "3", "4", "5" };
            String[] arr2 = { "1", "2"};
            String[] arr3 = { "-1", "-2", "-3" };
            Assert.Equal(6, Program.Program.Product(arr));
            Assert.Equal(6, Program.Program.Product(arr1));
            Assert.Equal(0, Program.Program.Product(arr2));
            Assert.Equal(-6, Program.Program.Product(arr3));
        }
        // test challenge 2 
        [Fact]
        public void TestAverage()
        {
            int[] arr = { 0, 0, 0, 0, 0 };
            int[] arr2 = { 1, 2, 3, 4, 5 };
            Assert.Equal(0, Program.Program.Avg(arr));
            Assert.Equal(3, Program.Program.Avg(arr2));

        }
        // test challenge 4 
        [Fact]
        public void TestMostFrequent()
        {
            int[] arr = { 0, 0, 0, 0, 0 };
            int[] arr2 = {1,1,2,2,3,3,3};
            int[] arr3 = { 1,2, 3,4,5};
            int[] arr4 = { 1,1,3,4,5,1};
            Assert.Equal(1, Program.Program.mostFrequent(arr));
            Assert.Equal(1, Program.Program.mostFrequent(arr2));
            Assert.Equal(1, Program.Program.mostFrequent(arr3));
            Assert.Equal(1, Program.Program.mostFrequent(arr4));
        }
        // test challenge 5
        [Fact]
        public void TestMax()
        {   int[] arr = { 1, 1, 1, 1, 1 };
            int[] arr2 = { -1, -2, -3, 4, 5 };
            Assert.Equal(1, Program.Program.Max(arr));
            Assert.Equal(5, Program.Program.Max(arr2));
        }
        // test challenge 9
        [Fact]
        public void TestWordsCount()
        {
            Assert.Equal("Good Morning", "[ Good:4],[Morning:7]");
            Assert.Equal("Good Morning", "[ Good:4],[Morning:7],123");
            Assert.Equal("Good Morning People", "[ Good:4].[Morning:7].[People:6].");

        }
    }
}
