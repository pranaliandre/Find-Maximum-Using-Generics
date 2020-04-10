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
        /// <summary>
        /// Method to find maximum of three float number
        /// </summary>
        [Test]
        public void GivenThreeFloat_ShouldReturnMaximumNumber()
        {
            float expected = 10.4F;
            float number1 = 2.5F;
            float number2 = 10.4F;
            float number3 = 6.6F;
            FindMaximumProblem findMaximum = new FindMaximumProblem();
            float maximum = findMaximum.FloatMaximum(number1, number2, number3); //find maximum number
            Assert.AreEqual(expected, maximum);
        }
        [Test]
        /// <summary>
        /// Method to find maximum of three string name 
        /// </summary>
        public void GivenThreeString_ShouldReturnMaximum()
        {
            string expected ="sanjivani";
            string name1 = "aryan";
            string name2 = "sanjivani";
            string name3 = "kimaya";
            FindMaximumProblem findMaximum = new FindMaximumProblem();
            string maximum = findMaximum.StringMaximum(name1, name2, name3); //find maximum name
            Assert.AreEqual(expected, maximum);
        }
    }
}