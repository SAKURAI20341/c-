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

            string text = Console.ReadLine();
            int[] text1 = text.Select(number => Convert.ToInt32(Char.GetNumericValue(number))).ToArray();
            int max = text1[0];
            int min = text1[0];

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] < min)
                {
                    min = (text1[i]);
                }
                if (text1[i] > max)
                {
                    max = text1[i];
                }

            }
            Array.Reverse(text1);
            foreach (int n in text1)
            {
                Console.Write(n);
            }



            Console.Write($"{max}{min}");
        }
    }
}