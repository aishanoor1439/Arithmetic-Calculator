using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: Taking two numbers from the user
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Input: Taking the arithmetic operator from the user
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            // Variable to hold the result of the operation
            double result = 0;

            // Switch case to perform the corresponding arithmetic operation
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case '/':
                    // Check for division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    // Invalid operator
                    Console.WriteLine("Error: Invalid operator. Please use +, -, *, or /.");
                    break;
            }
        }
    }
}
