using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{

    class Program
    {
        static void Main(string[] args)
        {



            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;
            for (int i = 0, z = 1; i < x; i++, z += 2)
            {
                Console.Write(new string(' ', y--));
                Console.Write(new string('*', z));
                Console.WriteLine();
            }



        }
    }
}