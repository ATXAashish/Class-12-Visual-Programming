using System;


namespace Program2
{
    internal class add2number
    {
        public void Display()
        {
            Console.WriteLine("Enter two number");
            int num1 =Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32 (Console.ReadLine());
            int sum = num1+ num2;
            Console.WriteLine("the sum of number is :" + sum);
        }
    }
}
