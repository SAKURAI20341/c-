using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
namespace ConsoleApp9
{
class Programm
{
    static void VasyaStyle(int value)
    {

        int[] numbers = { 2,3,7};
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int q = 0; q < 3; q++)
                {
                    if (numbers[i] *numbers[j] + numbers[q] == value)
                    {
                        
                       
                            Console.WriteLine($"{numbers[i]} * {numbers[j]} + {numbers[q]}");
                        
                    }
                }
            }
        }

        
    }

    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        VasyaStyle(number);

    }
}
}
