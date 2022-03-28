using System;

namespace Day_33_AddressBookAndPayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepo emprepository = new EmployeeRepo();  //Creating a object of EmployeeRepository class.

            emprepository.DataBaseConnection(); 

            EmployeeRepo.CreateTables();
            EmployeeModel emp = new EmployeeModel();

            emp.EmployeeName = "Ram";
            emp.Gender = "M";
            emp.BasicPay = 25000;
            emp.PhoneNumber = "9418987898";
            emp.City = "nag";
            emp.Country = "Ind";
            emp.Address = "Kagal";
            emp.Deductions = 1000;
            emp.TaxablePay = 2000;
            emp.Tax = 2000;
            emp.NetPay = 1000;
            emp.Department = "Sales";
            //emp.StartDate= "2022/3/28 10:52:41";
            emprepository.AddData(emp);
            Console.WriteLine("Record inserted");
        }
    }
}
