using NUnit.Framework;
using find_Maximum_Problem_Using_Generics;
namespace test_find_Maximum_Using_Generics
{
    public class FindMaximumTest
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Method to find maximum of three integer number
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2"> number2</param>
        /// <param name="number3"> number3</param>
        /// /// <return> maximum number </return>
        [Test]
        public void GivenThreeInteger_ShouldReturnMaximumNumber()
        {
            int expected = 10;
            int number1 = 2;
            int number2 = 10;
            int number3 = 6;
            FindMaximumProblem findMaximum = new FindMaximumProblem();
            int maximum = findMaximum.IntegerMaximum(number1, number2, number3); //find maximum number
            Assert.AreEqual(expected, maximum);
        }

    }
}