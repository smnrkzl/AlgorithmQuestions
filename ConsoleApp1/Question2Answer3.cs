using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Question2Answer3
    {
        public void question2Answer3() {


            //Write an application that returns the sum of squares of two numbers entered by the user.
            Console.WriteLine("Please enter number1 and number2");

            Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2));


        }
    }
}
