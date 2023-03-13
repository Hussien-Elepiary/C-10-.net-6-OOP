using Company_Class;
using Microsoft.VisualBasic;
using static Company_Class.Security;

namespace Assignment_01_OOP
{

    internal class Program
    {

        #region StartPoint
        static void Main()
        {
            try
            {
                int Qnumber;
                do
                {
                    Console.Write("For Static example press 1 // For Dynamic press 2 : ");

                } while (!int.TryParse(Console.ReadLine(), out Qnumber) || 0 >= Qnumber);

                switch (Qnumber)
                {
                    case 1:
                        #region Static Data
                        // this is just an example to show that you can do a class formate and have a mini example of enheretace 
                        try
                        {
                            Console.WriteLine("Format Date From onther Class");
                            DataFormater dateFormat = new DataFormater(11, 12, 1998);
                            Console.WriteLine(dateFormat);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        //static array
                        Console.WriteLine("Data From The Static array");
                        StaticData();
                        #endregion
                        break;
                    case 2:
                        #region Dynamic Data
                        try
                        {
                            GettingStarted();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        #endregion
                        break;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
        #endregion

        #region DynamicDataMethods
        private static void GettingStarted()
        {
            try
            {
                int employeeNumber;
                do
                {
                    Console.Write("Enter the number of Employees you want to enter : ");

                } while (!int.TryParse(Console.ReadLine(), out employeeNumber) || 0 >= employeeNumber);


                DataValidator(employeeNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private static void DataValidator(int employeeNumber)
        {
            try
            {
                Employee[] employee = new Employee[employeeNumber];
                InPuts(employeeNumber, employee);
                ShowData(employee, employeeNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void InPuts(int employeeNumber, Employee[] employee)
        {
            int _id = 1, _securityLevel;
            decimal _salary;
            bool _flag;
            char _gender;
            DataFormater dataFormater = new DataFormater(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);

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
                employee[i] = new Employee(_id, SetSecurityLevel(_securityLevel), _salary, dataFormater, _gender);
                #endregion
                _id++;
                Console.Clear();
            }
        }
        #endregion

        #region ShowSection
        private static void ShowData(Employee[] employee, int employeeNumber)
        {
            #region DataShow
            Console.Clear();

            try
            {
                int ShowNumber;
                do
                {
                    Console.Write("How Do You want to show the Data (1. HandMadeMethod || 2. ToString(overrideing)) : ");

                } while (!int.TryParse(Console.ReadLine(), out ShowNumber) || 0 >= ShowNumber);

                switch (ShowNumber)
                {
                    case 1:
                        for (int i = 0; i < employeeNumber; i++)
                        {
                            ShowDataWithAHandMadeMethod(employee, i);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < employeeNumber; i++)
                        {
                            ShowDataWithToStringOverrade(employee, i);
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion
        }
        private static void ShowDataWithAHandMadeMethod(Employee[] employee, int i)
        {
            Console.WriteLine("From To String for just the first Item for test");
            Console.WriteLine(employee[i].ShowEmployeeData());
            Console.WriteLine("---------------------------");
        }
        private static void ShowDataWithToStringOverrade(Employee[] employee, int i)
        {
            Console.WriteLine(employee[i]);
            Console.WriteLine("---------------------------");
        }
        #endregion

        #region securityLevelsHandler
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
        #endregion

        #region StaticDataHandler
        private static void StaticData()
        {
            Employee[] employee2 = new Employee[3];

            for (int i = 0; i < employee2.Length; i++)
            {
                employee2[i] = new Employee();
            }

            employee2[0].AddEmployee(1, securityLevels.DBA, 3000, new DataFormater(1, 30, 2023), 'F');
            employee2[1].AddEmployee(2, securityLevels.guest, 3000, new DataFormater(2, 20, 2023), 'M');
            employee2[2].AddEmployee(3, (securityLevels)15, 3000, new DataFormater(3, 29, 2023), 'F');

            DataFormater[] EmployeeHiringDate = new DataFormater[employee2.Length];
            for (int i = 0; i < employee2.Length; i++)
            {
                employee2[i].ShowEmployeeData();
                EmployeeHiringDate[i] = employee2[i].hiringDate;
            }

            DataFormater[] SortedDate = GetDateFromEmployeeAndSortIt(EmployeeHiringDate);
            ShowData(employee2, 3);

        }
        #endregion

        #region SortByHiringDate
        // Get Date From Employee
        private static DataFormater[] GetDateFromEmployeeAndSortIt(DataFormater[] Date)
        {
            DateTime[] ConvertedDate = new DateTime[Date.Length] ;
            DataFormater[] hiringDateSorted = new DataFormater[Date.Length];
            for (int i = 0; i < Date.Length; i++)
            {
                ConvertedDate[i] = new DateTime(Date[i].year, Date[i].month, Date[i].day);
            }
            Array.Sort(ConvertedDate);
            for (int i = 0; i < Date.Length; i++)
            {
                hiringDateSorted[i] = new DataFormater(ConvertedDate[i].Day, ConvertedDate[i].Month, ConvertedDate[i].Year);
            }
            return hiringDateSorted;
        }

        private static void SortingEmployees(Employee[] employee, DataFormater[] hiring)
        {
            if ( ((employee is not null) && (hiring is not null)) && (employee.Length == hiring.Length) )
            {
                for (int i = 0; i < employee.Length; i++)
                {
                   
                }
            }
        }
        #endregion
    }
}