using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculator
    {
        public static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Substraction(int n1, int n2)
        {
            return n1 - n2;
        }

        public static object Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        public static object Division(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
