using Assignment_02.BindingExample;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Qnumber;
            do
            {
                Console.Write("For overridingMethod press 1 \nFor BindingStartPoint press 2  \nFor SeriesTest press 3: ");

            } while (!int.TryParse(Console.ReadLine(), out Qnumber) || 0 >= Qnumber);

            switch (Qnumber)
            {
                case 1:
                    overridingMethod();
                    break;
                case 2:
                    BindingStartPoint();
                    break;
                case 3:
                    SeriesTest();
                    break;
            }
        }

        public static void overridingMethod()
        {
            Overriding overriding = new Overriding();
            overriding.overridingMethod();
        }

        public static void BindingStartPoint()
        {
            FullTime fullTime = new FullTime();
            Binding(fullTime);

            PartTime part = new PartTime();
            Binding(part);
        }


        public static void Binding(Employee employee) 
        {
            employee.MyFun01();
            employee.MyFun02();
        }

        public static void InterFaceTest()
        {
            //Not Valid
            //IMyType myType = new IMyType();
            //myType.Salary = 1;

            MyType myType = new MyType();
            myType.Salary = 100000;
            myType.MyFun();

            IMyType myType1 = new MyType();
            myType1.Salary = 100000;
            myType1.MyFun();
            myType1.Default();
        }

        public static void Print10NumbersFromSeries(ISeries series) 
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }
        }

        public static void SeriesTest()
        {
            Console.WriteLine("seriesOf2");
            SeriesOf2 seriesOf2 = new SeriesOf2();
            Print10NumbersFromSeries(seriesOf2);

            Console.WriteLine("seriesOf3");
            SeriesOf3 seriesOf3 = new SeriesOf3();
            Print10NumbersFromSeries(seriesOf3);

            // Not Valid
            //SeriesOf4 seriesOf4 = new SeriesOf4();
            //Print10NumbersFromSeries(seriesOf4);
        }
    }
}