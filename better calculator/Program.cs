using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace better_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Coloque um numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Coloque um sinal matemático: ");
            string op = Console.ReadLine();

            Console.Write("Coloque outro numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else 
            {
                Console.WriteLine("Numero invalido");
            }

            Console.ReadLine();
        }
    }
}
