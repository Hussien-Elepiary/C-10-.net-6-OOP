namespace Company_Class
{
    public class DataFormater : Employee
    {
        public int day { get; set; }
        public int month { get; set; }  
        public int year { get; set; }

        public DataFormater(int size, int day, int month, int year) : base(size)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public override string ToString()
        {
            return $"Day is: {day} \nMonth is: {month} \nYear is: {year}";
        }
    }
}
