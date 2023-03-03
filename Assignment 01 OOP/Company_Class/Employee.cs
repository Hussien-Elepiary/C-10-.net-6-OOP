using System.Diagnostics.Metrics;
using static Company_Class.Security;

namespace Company_Class
{
    public class Employee
    { 
        public int size { get; }
        public int[] id { get; set; }
        public securityLevels[] securityLevel { get; set; }
        public decimal[] salary { get; set; }
        public DateTime[] hiringDate { get; set; }
        public char[] gender { get; set; }

        // Gender Attrebute setter makes the defult val of gender 'M' if the input is any thing other than M or F

        public Employee(int size)
        {
            this.size = size;
            id = new int[size];
            salary = new decimal[size]; 
            hiringDate = new DateTime[size];    
            gender = new char[size];
            securityLevel = new securityLevels[size];
        }

        public void AddEmployee(int index, int id, securityLevels securityLevel, decimal salary, DateTime hiringDate, char gender)
        {
            if (index >= 0 && index < size)
            {
                this.id[index] = id;
                this.securityLevel[index] = securityLevel;
                this.salary[index] = salary;
                this.hiringDate[index] = hiringDate;
                this.gender[index] = gender;
            }
        }


        //indexer
        public string this[int id]
        {
            get 
            {
                int counter = 0;
                while (counter < size)
                {
                    if (id == this.id[counter])
                    {
                        return $"| Employee ID : {this.id[counter]} \n| Employee Level : {securityLevel[counter]} \n| Employee Salary : {salary[counter].ToString("0$")} \n| Employee Gender :{gender[counter]} \n| Employee HiringDate : {hiringDate[counter].ToString("d")}";
                    }
                    counter++;
                }
                return "There is No Employee With That ID";
            }
        }


        //public string GetEmployeeData(int id)
        //{
        //    int counter = 0;
        //    while (counter < size)
        //    {
        //        if (id == this.id[counter])
        //        {
        //            return $"| Employee ID : {this.id[counter]} \n| Employee Level : {securityLevel[counter]} \n| Employee Salary : {salary[counter].ToString("0$")} \n| Employee Gender :{gender[counter]} \n| Employee HiringDate : {hiringDate[counter].ToString("d")}";
        //        }
        //        counter++;
        //    }
        //    return "There is No Employee With That ID";
        //}

        public override string ToString()
        {
            return $"| Employee Salary From ToString : {string.Format("{0:C}", salary)}";
        }
    }
}
