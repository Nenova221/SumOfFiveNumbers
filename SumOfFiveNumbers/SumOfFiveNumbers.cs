using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SumOfFiveNumbers
{
    public class SumOfNumbers
    {
        public static int Sum(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber)
        {
            bool parseSucceed = false;
            Console.Write("Enter first number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            parseSucceed = Int32.TryParse(Console.ReadLine(), out number1);
            Console.Write("Enter second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            parseSucceed = Int32.TryParse(Console.ReadLine(), out number2);
            Console.Write("Enter third number: ");
            int number3 = Int32.Parse(Console.ReadLine());
            parseSucceed = Int32.TryParse(Console.ReadLine(), out number3);
            Console.Write("Enter fourth number: ");
            int number4 = Int32.Parse(Console.ReadLine());
            parseSucceed = Int32.TryParse(Console.ReadLine(), out number4);
            Console.Write("Enter fifth number: ");
            int number5 = Int32.Parse(Console.ReadLine());
            parseSucceed = Int32.TryParse(Console.ReadLine(), out number5);
            return number1 + number2 + number3 + number4 + number5; 
        }
        
    }
}
