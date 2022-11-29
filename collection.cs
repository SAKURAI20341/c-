using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<char> text = new List<char>(Console.ReadLine().ToCharArray());
            Console.Write(text.IndexOf('O'));
        }
    }
}

