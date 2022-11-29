using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static int[] Opposite(int[] x)
        {
            
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= -1;
                Console.Write(x[i] + " ");
            }

            return x;
        }
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            
            Opposite(arr);
        }
    }
}

