using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Question1inAnswer3
    {

        /*The try-catch structure is used to deal with error situations of programs. The purpose of this structure is to handle exceptions that occur during the execution of the code and handle them appropriately.*/
        /* try Block: This block contains code that can potentially throw an exception. The code is executed within this block, and if an exception occurs, the code within this block is stopped from executing before the exception is thrown. */
        /*catch Block: This block handles the exception raised within the try block. If an exception occurs, the catch block runs and exception-related operations are performed here. The catch block can be specified by exception type, and one or more catch blocks can handle exceptions that match the try block.*/
        public void answer3()
        {
			try
			{
                Console.WriteLine("please enter number1");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter number2");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(number1 + number2);
            }
			catch (Exception)
			{

                Console.WriteLine("Please enter a correct number");
			}
        }

    }
}
