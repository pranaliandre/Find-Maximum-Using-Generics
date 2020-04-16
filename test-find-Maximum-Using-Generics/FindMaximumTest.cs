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
            FindMaximumProblem<int> findMaximum = new FindMaximumProblem<int>(number1, number2, number3);
            int maximum = findMaximum.Maximum(); //find maximum number
            findMaximum.ToPrintMax(maximum);
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
            FindMaximumProblem<float> findMaximum = new FindMaximumProblem<float>(number1, number2, number3);
            float maximum = findMaximum.Maximum(); //find maximum number
            findMaximum.ToPrintMax(maximum);
            Assert.AreEqual(expected, maximum);
        }
        [Test]
        /// <summary>
        /// Method to find maximum of three string name 
        /// </summary>
        public void GivenThreeString_ShouldReturnMaximum()
        {
            string expected = "sanjivani";
            string name1 = "aryan";
            string name2 = "sanjivani";
            string name3 = "kimaya";
            FindMaximumProblem<string> findMaximum = new FindMaximumProblem<string>(name1, name2, name3);
            string maximum = findMaximum.Maximum(); //find maximum name
            findMaximum.ToPrintMax(maximum);
            Assert.AreEqual(expected, maximum);
        }


        /// <summary>
        /// Test Case For Testing dynamic Integer FindMaximum.
        /// </summary>
        [Test]
        public void GivenIntegerNumbers_FindMaximumValue()
        {
            int expected = 70;
            FindMaximumProblem<int> findMaximum = new FindMaximumProblem<int>();
            int max = findMaximum.DyanamicfindMaximumValue(70, 32, 43, 4, 67, 20, 13);
            Assert.AreEqual(expected, max);
        }
        /// <summary>
        /// Test Case For Testing dynamic Float FindMaximum.
        /// </summary>
        [Test]
        public void GivenFloatNumber_FindMaximumValue()
        {
            float expected = 7.0F;
            FindMaximumProblem<float> findMaximum = new FindMaximumProblem<float>();
            float max = findMaximum.DyanamicfindMaximumValue(7.0F, 3.2F, 4.3F, 4.7F, 6.7F, 2.0F, 1.3F);
            Assert.AreEqual(expected, max);
        }
        /// <summary>
        /// Test Case For Testing dynamic string FindMaximum.
        /// </summary>
        [Test]
        public void GivenStringName_FindMaximumValue()
        {
            string expected = "sanjivani";
            FindMaximumProblem<string> findMaximum = new FindMaximumProblem<string>();
            string max = findMaximum.DyanamicfindMaximumValue("kimaya","aryan","devram","sanjivani");
            Assert.AreEqual(expected, max);
        }
    }
}