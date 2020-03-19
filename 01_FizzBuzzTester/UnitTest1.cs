using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _01_FizzBuzzTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void DivisibleBy3()
        {
            List<int> numbers = new List<int>() { 3, 6, 9, 4 };

            List<string> expectedResult = new List<string>() { "Fizz", "Fizz", "Fizz", "4" };

            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DivisibleBy5()
        {
            List<int> numbers = new List<int>() { 5, 10, 20, 8 };

            List<string> expectedResult = new List<string>() { "Buzz", "Buzz", "Buzz", "8" };

            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DivisibleBy7()
        {
            List<int> numbers = new List<int>() { 7, 21, 49, 2 };

            List<string> expectedResult = new List<string>() { "Buzzinga", "Buzzinga", "Buzzinga", "2" };

            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DivisibleBy3And5()
        {
            List<int> numbers = new List<int>() { 15, 30, 45, 1 };

            List<string> expectedResult = new List<string>() { "FizzBuzz", "FizzBuzz", "FizzBuzz", "1" };

            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Apper5()
        {
            List<int> numbers = new List<int>() { 551, 1265, 5125 };

            List<string> expectedResult = new List<string>() { "Buzz", "Buzz", "Buzz" };

            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Apper3And5()
        {
            List<int> numbers = new List<int>() { 153, 4351, 3553 };

            List<string> expectedResult = new List<string>() { "FizzBuzz", "FizzBuzz", "FizzBuzz" };

            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void MoreRealisticTest()
        {
            List<int> numbers = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<string> expectedResults = new List<string>() {
                "1","2","Fizz","4","Buzz","Fizz","Buzzinga","8","Fizz","Buzz",
                 "11","Fizz","13","Buzzinga","FizzBuzz","16","17","Fizz","19","Buzz"};
            List<string> result = _01_FizzBuzz.Program.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, result);
        }

    }
}
