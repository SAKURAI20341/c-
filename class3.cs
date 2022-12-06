using System;


namespace lab
{
    class Vector
    {
        public float x;
        public float y;
        public float z;




        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static double Distance(Vector a, Vector b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2) + Math.Pow(b.z - a.z, 2));
        }

        public static double Path(Vector a, Vector b)
        {
            double n = Distance(a, new Vector(b.x, b.y, a.z));
           double m = Distance(new Vector(b.x, b.y, a.z), b);
            return n + m;
        }
    }

    class Program
    {
        
        
        static void Main()
        {
            Vector Spider = new Vector(5, 1, 1), Fly = new Vector(2, 0, 0);
            if (Fly.z == 0)
            {
                Console.WriteLine("Муха на полу");
                double a = Vector.Distance(Spider, Fly);
                double b = Vector.Path(Spider, Fly);
                Console.WriteLine(a);
                Console.WriteLine(b);

            }

        }
    }
}