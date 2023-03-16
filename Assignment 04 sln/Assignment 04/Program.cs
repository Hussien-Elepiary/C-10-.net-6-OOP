using Assignment_04.Partial;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(math.Add(1, 1));
            Console.WriteLine(math.Sub(2, 2));
            Console.WriteLine(math.Mul(3, 3));
            Console.WriteLine(math.Div(4, 4));

            partialclass partialclass = new partialclass();
            partialclass.X = 1;
            partialclass.Y = 2;
        }
    }
}