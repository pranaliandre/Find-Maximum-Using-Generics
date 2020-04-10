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
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("!!!Welcome to find maximum number!!!");
        }
    }
}
