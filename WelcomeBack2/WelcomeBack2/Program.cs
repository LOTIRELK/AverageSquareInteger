using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a program that reads an integer and outputs its square. Reads 2 decimal values and outputs their average
namespace WelcomeBack2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt to enter number
            Console.WriteLine("Please enter a number.");
           string input= Console.ReadLine();
            int value;
            if (int.TryParse(input, out value)) //convert string to int value
            {
                Console.Write("Integer squared = ");
                Console.WriteLine(value * value); // Multiply the integer by itself to get answer
            }

            //prompt to enter first number
            Console.WriteLine("Please enter first number.");
            string input2 = Console.ReadLine();
            float value2;
            //prompt to enter second number
            Console.WriteLine("Please enter second number.");
            string input3 = Console.ReadLine();
            float value3;
            float.TryParse(input2, out value2);//convert to decimal(float) value2
            float.TryParse(input3, out value3);//convert to deciaml(float) value3 
            Console.Write("Average = ");
            Console.WriteLine((value2 + value3)/2);//add value2 and value 3, then divide by 2 to get the average
           


        }
    }
}
