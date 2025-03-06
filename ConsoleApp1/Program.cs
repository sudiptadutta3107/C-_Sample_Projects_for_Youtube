using System;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main()
        {
            String Operator = string.Empty;

            do
            {
                Console.Write("\n Enter first number: ");
                int FirstNumber = int.Parse(Console.ReadLine());

                Console.Write("\n Enter second number: ");
                int SecondNumber = int.Parse(Console.ReadLine());

                Console.Write("\n Enter the operator [+ - * /]: ");
                Operator = Console.ReadLine();

                if(Operator == "+")
                {
                    Console.Write("Addition = {0} ", MathsLibrary.Calculator.Addition(FirstNumber, SecondNumber));
                }
                else if (Operator == "-")
                {
                    Console.Write("Substraction = {0} ", MathsLibrary.Calculator.Substraction(FirstNumber, SecondNumber));
                }
                else if (Operator == "*")
                {
                    Console.Write("Multiplication = {0} ", MathsLibrary.Calculator.Multiplication(FirstNumber, SecondNumber));
                }
                else if (Operator == "/")
                {
                    Console.Write("Division = {0} ", MathsLibrary.Calculator.Division(FirstNumber, SecondNumber));
                }
                else
                {
                    Console.Write("Invalid operator");
                }               


            } while (Operator != string.Empty);            
        }
    }
}
