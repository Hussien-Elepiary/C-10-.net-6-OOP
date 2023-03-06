using System.Diagnostics.Metrics;
using System.Drawing;
using static Company_Class.Security;

namespace Company_Class
{
    public class Employee
    { 
        public int id { get; set; }
        public securityLevels securityLevel { get; set; }
        public decimal salary { get; set; }
        public DataFormater hiringDate { get; set; }
        public char gender { get; set; }

        // Gender Attrebute setter makes the defult val of gender 'M' if the input is any thing other than M or F

        public Employee()
        {
            // this Ctor is for the static Data example 
        }
        public Employee(int _id, securityLevels _securityLevel, decimal _salary, DataFormater _hiringDate, char _gender)
        {
            id = _id;
            securityLevel = _securityLevel;
            salary = _salary;
            gender = _gender;
            hiringDate = _hiringDate;
        }

        public void AddEmployee(int _id, securityLevels _securityLevel, decimal _salary, DataFormater _hiringDate, char _gender)
        {
            id = _id;
            securityLevel = _securityLevel;
            salary = _salary;
            gender = _gender;
            hiringDate = _hiringDate;
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

        public string ShowEmployeeData()
        {
            return $"| Employee ID : {id} \n| Employee Level : {securityLevel} \n| Employee Salary : {salary.ToString("0$")} \n| Employee Gender :{gender} \n| Employee HiringDate : {hiringDate}";
        }
    }
}
