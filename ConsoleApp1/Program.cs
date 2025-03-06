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

                switch (Operator)
                {
                    case "+":
                        Console.Write("Addition = {0} ", MathsLibrary.Calculator.Addition(FirstNumber, SecondNumber));
                        break;
                    case "-":
                        Console.Write("Substraction = {0} ", MathsLibrary.Calculator.Substraction(FirstNumber, SecondNumber));
                        break;
                    case "*":
                        Console.Write("Multiplication = {0} ", MathsLibrary.Calculator.Multiplication(FirstNumber, SecondNumber));
                        break;
                    case "/":
                        Console.Write("Division = {0} ", MathsLibrary.Calculator.Division(FirstNumber, SecondNumber));
                        break;
                    default:
                        Console.Write("Invalid operator");
                        break;
                }
            } while (Operator != string.Empty);


            
        }
    }
}
