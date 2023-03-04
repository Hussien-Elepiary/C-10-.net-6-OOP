using Company_Class;
using static Company_Class.Security;

namespace Assignment_01_OOP
{
    
    internal class Program
    {
        
        static void Main()
        {
            #region Dynamic Data
            try
            {
                GettingStarted();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // this is just an example to show that you can do a class formate and have a mini example of enheretace 
            Console.WriteLine("Format Date From onther Class");
            DataFormater dateFormat = new DataFormater(1, 11, 12, 1998);
            Console.WriteLine(dateFormat);
            #endregion

            #region Static Data
            ////static array
            //Console.WriteLine("Data From The Static array");
            //StaticData();
            #endregion
        }

        private static void GettingStarted()
        {
            int employeeNumber;
            do
            {
                Console.Write("Enter the number of Employees you want to enter : ");

            } while (!int.TryParse(Console.ReadLine(), out employeeNumber) || 0 >= employeeNumber);

            
            DataValidator(employeeNumber);
        }

        private static void DataValidator(int employeeNumber)
        {
            Employee employee = new Employee(employeeNumber);

            InPuts(employeeNumber, employee);   
            ShowData(employee, employeeNumber);

            
        }

        private static void InPuts(int employeeNumber, Employee employee)
        {
            int _id = 1, _securityLevel;
            decimal _salary;
            bool _flag;
            char _gender;

            for (int i = 0; i < employeeNumber; i++)
            {
                #region Inputs 
                do
                {
                    Console.WriteLine("Set the employee Security Level.\nChoose From the Following \n1- guest.\n2- Developer. \n3- secretary. \n4- DBA.");
                    Console.Write($"Type the number of the level For Employee {_id} : ");
                } while (!int.TryParse(Console.ReadLine(), out _securityLevel) || 0 >= _securityLevel || 4 < _securityLevel);
                do
                {
                    Console.Write($"Enter Employee salary For Employee {_id} : ");
                } while (!decimal.TryParse(Console.ReadLine(), out _salary) || 0 >= _salary);
                do
                {
                    Console.Write($"Enter Employee gender ( 'M' for Male, 'F' For Female ) For Employee {_id} : ");
                    char.TryParse(Console.ReadLine(), out _gender);
                    _flag = (_gender.ToString().ToLower() == "m" || _gender.ToString().ToLower() == "f") ? true : false;

                } while (!_flag);
                #endregion
                #region Add
                employee.AddEmployee(i, _id, SetSecurityLevel(_securityLevel), _salary, DateTime.Now, _gender);
                #endregion
                _id++;
                Console.Clear();
            }
        }

        private static void ShowData(Employee employee, int employeeNumber)
        {
            #region DataShow
            Console.Clear();
            for (int i = 1; i <= employeeNumber; i++)
            {
                Console.WriteLine(employee[i]);
                Console.WriteLine("---------------------------");
               
            }

            Console.WriteLine("From To String for just the first Item for test");
            Console.WriteLine(employee.ToString());
            Console.WriteLine("---------------------------");
            #endregion
        }

        private static securityLevels SetSecurityLevel(int securityLevel)
        {
            switch (securityLevel)
            {
                case 1:
                    return securityLevels.guest;
                case 2:
                    return securityLevels.Developer;
                case 3:
                    return securityLevels.secretary;
                case 4:
                    return securityLevels.DBA;
                default:
                    return securityLevels.guest;
            }
        }

        private static void StaticData()
        {
            Employee employee2 = new Employee(3);
            employee2.AddEmployee(0, 1, securityLevels.DBA, 3000, DateTime.Parse("1/30/2023"),'F');
            employee2.AddEmployee(1, 2, securityLevels.guest, 3000, DateTime.Parse("2/1/2023"), 'M');
            employee2.AddEmployee(2, 3, (securityLevels) 15, 3000, DateTime.Parse("3/1/2023"), 'F');

            ShowData(employee2, 3);

        }
    }
}