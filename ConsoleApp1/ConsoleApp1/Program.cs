namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area(4));
            Console.WriteLine(Area(5, 7));
            Console.WriteLine(Area(2, 4, 6));
            Console.WriteLine(Area(10, 8, 5, 3));
        }

        static int Area(int r)
        {
            int pi = 3;
            int area = pi * (r * r);
            return area;
        }
        static int Area(int a, int b)
        {
            int area = a * b;
            return area;
        }
        static int Area(int a, int b, int c)
        {
            int area = 2 * ((a * b) + (c * a) + (b * c));
            return area;
        }
        static int Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            int area = p * r;
            return area;
        }
    }
}
