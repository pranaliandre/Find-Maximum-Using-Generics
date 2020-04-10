using System;
namespace find_Maximum_Problem_Using_Generics
{
    public class FindMaximumProblem<T> where T : IComparable
    {
        /// <summary>
        /// Method to find maximum number to given three integer number
        /// </summary>
        /// <param name="number1">First integer number</param>
        /// <param name="number2">Second integer number</param>
        /// <param name="number3">Third integer number</param>
        /// <returns>maximum number</returns>
        public T Maximum(T number1, T number2, T number3)
        {
            T maximumNo = number1;
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
    }
     public class FindMaximum
     {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("!!!Welcome to find maximum number!!!");
            FindMaximumProblem<int> findIntegerNumber = new FindMaximumProblem<int>();
            FindMaximumProblem<float> findFloatNumber = new FindMaximumProblem<float>();
            FindMaximumProblem<string> findStringNumber = new FindMaximumProblem<string>();
            int integerMaximum = findIntegerNumber.Maximum(10,2,6);
            Console.WriteLine("Maximum integer number : "+integerMaximum);
            float floatMaximum = findFloatNumber.Maximum(1.1F, 10.5F, 6.6F);
            Console.WriteLine("Maximum float number : "+floatMaximum);
            string stringMaximum = findStringNumber.Maximum("Sanjivani","aryan","kimaya");
            Console.WriteLine("Maximum string name : "+stringMaximum);
        }
        /// <summary>
        /// Method to Compare Interface Implementation 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
