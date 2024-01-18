using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
     
        public class question7
    {
        public void Display()
        {


            int a = 25;
            int b = 4;
            int sum;
            int minus;
            int multiply;
            int divide;
            int mod;

            sum =a+b ;
            minus = a - b;
            multiply = a * b;
            divide = a / b;
            mod = a % b;
            Console.WriteLine("25+4="+sum);
            Console.WriteLine("25-4=" + minus);
            Console.WriteLine("25*4=" + divide);
            Console.WriteLine("25/4=" + multiply);
            Console.WriteLine("25mod4=" + mod);


        }
        
    }
}
