using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Question2inAnswer2
    {
        public void question2answer2()
        {
            //Write an application that returns the sum of squares of two numbers entered by the user.
            Console.WriteLine("Please enter number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number2");
            int number2 = int.Parse(Console.ReadLine());


            /*Math.pow(x, y): This function calculates the y prime on the base x. That is, the expression Math.pow(number1, 2) squares the variable number1.*/
            double result = Math.Pow(number1, 2) + Math.Pow(number2,2);
            Console.WriteLine(result);

        }
    }
}
