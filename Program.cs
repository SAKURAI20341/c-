using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 5;
            for(int i=0;i<n;i++)
            {
                a=a+ 1;
                b = b + 5;
                if(a==13)
                {
                    a = 1;
                }
                if(b==60)
                {
                    b = 0;
                }
            }
            if (b == 5 || b == 0)
            {
                Console.WriteLine($"{a}:0{b}");
            }
            else
            { 
                Console.WriteLine($"{a}:{b}"); 
            }
        }
    }
}
