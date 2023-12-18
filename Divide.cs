using System;


namespace ConsoleApp1
{
   public class Divide
    {
        public void Display()
        {
            Console.WriteLine("Enter two number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int div = num1 /num2;
            Console.WriteLine("the div of number is :" + div);
        }
    }
}
    

