using System;

class Sequence
{
    public Sequence(int x)
    {
        for (int i = 0; i <= x; i++)
        {
            Console.Write(i + " ");
        }
    }

    public Sequence(int y, int x)
    {
        for (int i = y; i <=x; i++)
        {
            Console.Write(i + " ");
        }
    }

    public Sequence(char x)
    {
        for (int i = 97; i <= (int)x; i++)
        {
            Console.Write((char)i + " ");
        }
    }

    public Sequence(char y, char x)
    {
        for (int i = (int)y; i <= (int)x; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}



class lab
{
    

   
    static void Main()
    {
         Sequence x= new Sequence(5,12);

    }
}