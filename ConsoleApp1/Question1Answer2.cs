using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Question1Answer2
    {

        public void answer1in2()
        {
            //Write an application that returns the sum of two numbers(values will be received from the user)

            /*Console.ReadLine(): This method allows receiving an input from the user. It waits until the user enters a value when the program is run.*/

            /*Convert.ToInt32():This method allows converting a specific value to an integer. The input received with the Console.ReadLine() method is initially considered as a text (string). Convert.ToInt32() method converts this textual value to integer*/

            /*int.Parse(): This method allows converting a specific value to an integer. The input received with the Console.ReadLine() method is initially considered as a text (string). The int.Parse() method converts this textual value to an integer.*/

            Console.WriteLine("please enter number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1+number2);


        }
    }
}
