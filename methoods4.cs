using System;
using System.Collections.Generic;
namespace ConsoleApp9
{
 class programm
{
    static void PrintEven(List<int> Print)
    {
        
        for(int i=0;i<Print.Count; i++)
        {
            if ( i% 2 == 1)
                Console.Write(Print[i] + " ");
            
        }
        
    }

    static List<int> GetMultiple(int startValue, int endValue)
    {
        List<int> num = new List<int>();
        for (int i = startValue; i <= endValue; i++)
        {
            if (i % 7 == 0 && i != 0)
            {
                num.Add(i);
            }
        }
        return num;
    }
    static void Main(string[] args)
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        PrintEven(GetMultiple(startValue, endValue));
    }
}
}
