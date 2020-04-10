using System;
namespace find_Maximum_Problem_Using_Generics
{
    public class FindMaximumProblem
    {
        /// <summary>
        /// Method to find maximum number to given three integer number
        /// </summary>
        /// <param name="number1">First integer number</param>
        /// <param name="number2">Second integer number</param>
        /// <param name="number3">Third integer number</param>
        /// <returns>maximum number</returns>
        public int IntegerMaximum(int number1, int number2, int number3)
        {
            int maximumNo = number1;
            if (number2.CompareTo(maximumNo) > 0)
            {
                maximumNo = number2;
            }
            if (number3.CompareTo(maximumNo) > 0)
            {
                maximumNo = number3;
            }
            return maximumNo;
        }
        /// <summary>
        /// Method to find maximum number to given three float number
        /// </summary>
        /// <param name="number1">First float number</param>
        /// <param name="number2">Second float number</param>
        /// <param name="number3">Third float number</param>
        /// <returns>Maximum number</returns>
        public float FloatMaximum(float number1, float number2, float number3)
        {
            float maximumNo = number1;
            if (number2.CompareTo(maximumNo) > 0)
            {
                maximumNo = number2;
            }
            if (number3.CompareTo(maximumNo) > 0)
            {
                maximumNo = number3;
            }
            return maximumNo;
        }
        /// <summary>
        /// Method
        /// </summary>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        /// <param name="name3"></param>
        /// <returns>maximum string name</returns>
        public string StringMaximum(string name1, string name2, string name3)
        {
            string maximumName = name1;
            if (name2.CompareTo(maximumName) > 0)
            {
                maximumName = name2;
            }
            if (name3.CompareTo(maximumName) > 0)
            {
                maximumName = name3;
            }
            return maximumName;
        }
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("!!!Welcome to find maximum number!!!");
        }
    }
}
