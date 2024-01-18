using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class question8
    {
        public void Display()
        {
            string str = "abc";
            char[] str1= str.ToCharArray();
            Array.Reverse(str1);
            string revStr = new string(str1);
            Console.WriteLine(revStr);
            
        }
    }
}
