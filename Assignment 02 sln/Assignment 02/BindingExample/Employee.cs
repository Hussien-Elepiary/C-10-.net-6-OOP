namespace Assignment_02.BindingExample
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void MyFun01()
        {
            Console.WriteLine("Iam Employee");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee : id = {ID}, Name = {Name}, Age = {Age}");
        }
    }
    class FullTime:Employee 
    {
        public decimal Salary { get; set; }
        public new void MyFun01()
        {
            Console.WriteLine("Iam FullTimeEmployee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee : id = {ID}, Name = {Name}, Age = {Age}, Salary = {Salary}");
        }
    }
    class PartTime:Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHour { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("Iam PartTimeEmployee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee : id = {ID}, Name = {Name}, Age = {Age}, HourRate = {HourRate}, CountOfHour = {CountOfHour} ");
        }
    }
}
