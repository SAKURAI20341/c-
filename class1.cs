using System;


namespace lab
{
    class Program
    {
        class Worker
        {
            private string Name;
            private string Surname;
            private int Rate;
            private int Days;
            public Worker(string a, string b, int c, int d)
            {
                Name =a;
                Surname =b;
                Rate =c;
                Days = d;
            }
            public string GetFullName()
            {
                return Name + " " + Surname;
            }

            public int Getsalary()
            {
                return Rate * Days;

            }
        }
           
        public static void Main()
        {
            Worker Diluk = new Worker("Diluk", "Imba", 500, 9);
            Console.WriteLine(Diluk.GetFullName());
            Console.WriteLine((int)Diluk.Getsalary());
           }
    }
}