using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_with_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            string op; 

            //Ask user yo input 1st num
            Console.Write("Enter first num: ");
            num1 = float.Parse(Console.ReadLine());

            //Ask user to input 2nd num
            Console.Write("Enter second num: ");
            num2 = float.Parse(Console.ReadLine());

            //Ask user to input operator(+,-,*,/)
            Console.Write("Choose Operator(+, -, *, /): ");
            op = Console.ReadLine();

            switch (op)
            {   // if user enter + it will add the two num
                case "+":
                    float sum = num1 + num2;
                    Console.WriteLine("Sum is: " + sum);
                    break;
                // if user enter - it will subtract the two num
                case "-":
                    float diff = num1 - num2;
                    Console.WriteLine("Difference is: " + diff);
                    break;
                // if user enter * it will multiply the two num
                case "*":
                    float prod = num1 * num2;
                    Console.WriteLine("Product is: " + prod);
                    break;
                // if user enter / it will divide the two num
                case "/":
                    float quo = num1 / num2;
                    // if the secnd num is 0 in will not divide
                    if (num2 == 0)
                    {
                        Console.WriteLine("Invalid second num must not be Zero");
                    }
                    else
                    {
                        Console.WriteLine("Quotient is: " + quo);
                    }
                    break;


            }

        }
    }
}
