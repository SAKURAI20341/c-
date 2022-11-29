using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static bool Text(string text)
        {
            if (text.Contains("e") || text.Contains("E"))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool a = Text(text);
            if (a)
                Console.WriteLine("Есть буква е, только латинская");
            else
                Console.WriteLine(" нету");
        }
    }
}
