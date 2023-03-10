using First_Project;
using Second_Project;

namespace Assignment_03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Qnumber;
            do
            {
                Console.Write("For Static FirstProject 1 // For SecondProject 2 : ");

            } while (!int.TryParse(Console.ReadLine(), out Qnumber) || 0 >= Qnumber);

            switch (Qnumber)
            {
                case 1:
                    FirstProject();
                    break;
                case 2:
                    SecondProject();
                    break;
            }
        }
        static void FirstProject()
        {

            //Console.Write("Enter First Point Coordinates : ");

            // Qnumber = Convert.ToPoint(Console.ReadLine()); // There is No ToPoint in Convert

            // Qnumber = Point.Parse(Console.ReadLine()); //Error 'Point' does not contain a definition for 'TryParse'

            // Point.TryParse(Console.ReadLine(), out Qnumber); //Error  'Point' does not contain a definition for 'TryParse'


            Point P1 = new Point(1, 2, 3);
            Point P2 = new Point(1, 2, 3);
            Point P3 = new Point(2, 1, 3);
            Point P4 = new Point(2, 2, 1);
            Point P5 = new Point(2, 2, 1);

            Point[] PArr = new Point[] { P1, P2, P3, P4, P5, P1 };

            Array.Sort(PArr);
            foreach (Point P in PArr)
            {
                Console.WriteLine(P);
            }

            Point PArr02 = (Point)PArr.Clone();

            //this code have no syntax Errors but in the run time it dosn`t work because there is no logic for == oprator to do in Point 
            if (P1 == P2)
            {
                Console.WriteLine(" == It Works properly ");
            }
            else
            {
                Console.WriteLine(" ==  !(Works properly) ");
            }

        }

        static void SecondProject()
        {
            start();
        }

        static void start()
        {
            Duration D0 = new Duration(1, 10, 15);
            D0.ToString();
            Duration D1 = new Duration(3600);
            D1.ToString();
            Duration D2 = new Duration(7800);
            D2.ToString();
            Duration D3 = new Duration(666);
            D3.ToString();

            Operators(D1, D2, D3);
        }
        static void Operators(Duration _d1 , Duration _d2 , Duration _d3)
        {
            int Qnumber;
            do
            {
                Console.Write("For + Press 1 \nFor ++ And -- Press 2\nFor - press3 \nFor Logical Oprators press 4 \nFor Casting press 5: ");

            } while (!int.TryParse(Console.ReadLine(), out Qnumber) || 0 >= Qnumber || Qnumber > 6);

            switch (Qnumber)
            {
                case 1:
                    plusOverloading(_d1, _d2);
                    break;
                case 2:
                    PlusPlusMinusMinus(_d1, _d2);
                    break;
                case 3:
                    Minus(_d1, _d2);
                    break;
                case 4:
                    LogicalOprators(_d1 , _d2);
                    break;
                case 5:
                    Casting(_d1);
                    break;

            }

        }
        public static void plusOverloading(Duration D1 , Duration D2) 
        {
            Duration D3;
            Console.WriteLine(" + OverLoading");
            D3 = D1 + D2;
            D3.ToString();
            D3 = D1 + 7800;
            D3.ToString();
            D3 = 666 + D1;
            D3.ToString();
        }
        public static void PlusPlusMinusMinus(Duration D1 , Duration D2)
        {
            Duration D3;
            Console.WriteLine(" ++ And -- OverLoading");
            D3 = ++D1;
            D3.ToString();
            D3 = --D2;
            D3.ToString();
        }
        public static void Minus(Duration D1, Duration D2)
        {
            Console.WriteLine(" - OverLoading");
            D1 = D1 - D2;
            D1.ToString();
        }
        public static void LogicalOprators(Duration D1, Duration D2)
        {
            Console.WriteLine(" > OverLoading");
            if (D1 > D2)
                Console.WriteLine($"D1 > D2 From If:{D1 > D2}");
            else
                Console.WriteLine($"D1 > D2 From else:{D1 > D2}");

            Console.WriteLine();

            Console.WriteLine(" <= OverLoading");
            if (D1 <= D2)
                Console.WriteLine($"D1 <= D2 From if:{D1 <= D2}");
            else
                Console.WriteLine($"D1 <= D2 From else:{D1 <= D2}");

            Console.WriteLine();

            Console.WriteLine(" True False OverLoading ");
            if (D1)
                Console.WriteLine($"D1 From if:{D1}");
            else
                Console.WriteLine($"D1 From else:{D1}");
        }
        public static void Casting(Duration D1)
        {
            Console.WriteLine("DateTime OverLoading");
            DateTime Time = (DateTime)D1;
            Console.WriteLine(Time);
        }

    }
}