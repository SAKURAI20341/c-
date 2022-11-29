using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = { 3, 1, 124, 423, 2, 3, 5, 2, 0 };
            for (int i = 0; i < X.Length; i++)
                for (int j = 0; j < X.Length - i - 1; j++)
                {
                    if (X[j] >X[j + 1])
                    {
                        int temp = X[j];
                        X[j] = X[j + 1];
                        X[j + 1] = temp;
                    }
                }
            foreach (int x in X)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
    

