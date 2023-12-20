using System;
///multiyply three number

namespace ConsoleApp1
{
    public class question5
    {
        public void Display() {
            Console.WriteLine("enter three number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mul = num1 * num2*num3;
            Console.WriteLine("the mul of number is :" + mul);

        }
    }
}
