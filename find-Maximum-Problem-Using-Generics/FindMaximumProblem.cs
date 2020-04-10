using System;
namespace find_Maximum_Problem_Using_Generics
{
    public class FindMaximumProblem<T> where T : IComparable
    {
        /// <summary>
        /// variable
        /// </summary>
        readonly T number1;
        readonly T number2;
        readonly T number3;
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="number1">first input</param>
        /// <param name="number2">first input</param>
        /// <param name="number3">first input</param>
        public FindMaximumProblem(T number1,T number2,T number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
        }
        /// <summary>
        /// Method to find maximum number to given three integer number
        /// </summary>
        /// <param name="number1">First input</param>
        /// <param name="number2">Second input</param>
        /// <param name="number3">Third input</param>
        /// <returns>maximum number</returns>
        public T Maximum()
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
        public void ToPrintMax(T maximumNo)
        {
            Console.WriteLine("maximum: "+maximumNo);
        }
    }
    public class FindMaximum
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            Console.WriteLine("!!!Welcome to find maximum number!!!");
            FindMaximumProblem<int> findIntegerNumber = new FindMaximumProblem<int>(10, 2, 6);
            FindMaximumProblem<float> findFloatNumber = new FindMaximumProblem<float>(1.1F, 10.5F, 6.6F);
            FindMaximumProblem<string> findStringNumber = new FindMaximumProblem<string>("Sanjivani", "aryan", "kimaya");
            int integerMaximum = findIntegerNumber.Maximum();
            findIntegerNumber.ToPrintMax(integerMaximum);
            float floatMaximum = findFloatNumber.Maximum();
            findFloatNumber.ToPrintMax(floatMaximum);
            string stringMaximum = findStringNumber.Maximum();
            findStringNumber.ToPrintMax(stringMaximum);
        }
        /// <summary>
        /// Method to Compare Interface Implementation 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        //public int CompareTo(object )
       // {
       //     throw new NotImplementedException();
       // }
    }
}