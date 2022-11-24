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
            int h = 0;
            string text = Console.ReadLine();
            string text1 = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == text1[i])
                {
                    h++; ;
                }
            }
            Console.WriteLine($" совпадений {h} элементов:");
        }
    }
}