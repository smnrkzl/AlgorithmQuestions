using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Question2inAnswer1
    {
        public void answer1()
        {
            //Write an application that returns the sum of squares of two numbers entered by the user.
            Console.WriteLine("Please enter number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number2");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 * number1 + number2 * number2;
            Console.WriteLine(result);
        }
    }
}
