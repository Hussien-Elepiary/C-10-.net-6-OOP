namespace Assignment_02
{
    internal class Overloading
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int sum(int[] x)
        {
            int result = 0;
            for (int i = 0; i < x.Length; i++)
            {
                result = result + x[i];
            }

            return result;
        }
    }
}
