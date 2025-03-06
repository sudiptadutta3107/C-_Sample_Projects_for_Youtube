using System;
using ConsoleApp1;

namespace ConsoleApp1
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
                        Console.Write("Addition = {0} ", Calculator.Addition(FirstNumber, SecondNumber));
                        break;
                    case "-":
                        Console.Write("Substraction = {0} ", Calculator.Substraction(FirstNumber, SecondNumber));
                        break;
                    case "*":
                        Console.Write("Multiplication = {0} ", Calculator.Multiplication(FirstNumber, SecondNumber));
                        break;
                    case "/":
                        Console.Write("Division = {0} ", Calculator.Division(FirstNumber, SecondNumber));
                        break;
                    default:
                        Console.Write("Invalid operator");
                        break;
                }
            } while (Operator != string.Empty);


            
        }
    }
}
