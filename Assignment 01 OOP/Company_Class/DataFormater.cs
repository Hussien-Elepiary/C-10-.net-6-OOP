namespace Company_Class
{
    public struct DataFormater 
    { 
        public int day { get; set; }
        public int month { get; set; }  
        public int year { get; set; }

        public DataFormater(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
