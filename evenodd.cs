using System;


namespace ConsoleApp1
{
    public class evenodd
    {
        public void Dispaly() {
            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
          

            if (num1 % 2 ==0) {
                Console.WriteLine("number is even");


            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
    }

