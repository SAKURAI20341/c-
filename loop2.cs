using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MainClass
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = number * 3 + 1;
            }
            count++;
        }
        Console.WriteLine($"Количество необходимых действий над числом - {count}");
    }
}