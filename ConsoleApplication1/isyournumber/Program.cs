using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isyournumber
{
    class Program
    {
             static void Main(string[] args)
        {
            string ans;
            int a = 0, b = 100;
            int count = 1;
            while(b > a+1)
            {
                int c = (a + b) / 2;
                Console.Write("Q{0}: Is your number less than {1}?",count ,c);
                ans = Console.ReadLine();
                if (ans == "Y")
                    b = c - 1;
                if (ans == "N")
                    a = c;
                count++;
            }
            Console.Write("Is your number {0}?", a);
            ans = Console.ReadLine();
            if (ans == "Y")
                Console.Write("Your number is {0} ", a);
            if (ans == "N")
                Console.Write("Your number is {0} ", b);

        }
    }
}
