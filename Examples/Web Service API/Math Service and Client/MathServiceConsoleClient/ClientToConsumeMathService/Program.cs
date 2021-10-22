/* This program prompts for 2 numbers and performs basic math.
 * The math methods for Add, Subtract, Multiply and Divide
 * reside in a Web Service called MathService that runs on the local
 * server (localhost).
 * This web service must be listening before this program can be executed.
 * Be sure to load project MathService and press Start to enable listening 
 */

using static System.Console;

namespace ClientToConsumeMathService
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a proxy object in order to expose methods
            localhost.MathService myMathService = new localhost.MathService();

            double num1, num2;

            Write("Enter first number: ");
            double.TryParse(ReadLine(), out num1);
            Write("Enter second number: ");
            double.TryParse(ReadLine(), out num2);

            WriteLine("{0} + {1} = {2}", num1, num2, myMathService.Add(num1, num2));
            WriteLine("{0} - {1} = {2}", num1, num2, myMathService.Subtract(num1, num2));
            WriteLine("{0} * {1} = {2}", num1, num2, myMathService.Multiply(num1, num2));
            WriteLine("{0} / {1} = {2}", num1, num2, myMathService.Divide(num1, num2));

            WriteLine("press enter to end program");
            ReadLine();
        }
    }
}
