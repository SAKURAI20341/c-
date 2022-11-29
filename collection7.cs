using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1met
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> text = new List<string>(Console.ReadLine().Split(' '));
            text.RemoveAll(x => x.Contains("1"));
            foreach (string a in text)
            {
                Console.Write(a + " ");
            }
        }
    }
}

