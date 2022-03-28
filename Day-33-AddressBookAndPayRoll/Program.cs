using System;

namespace Day_33_AddressBookAndPayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepo emprepository = new EmployeeRepo();  //Creating a object of EmployeeRepository class.

            emprepository.DataBaseConnection(); // UC1 Ensuring the database connection using the sql connection string
            //emprepository.GetAllRecord();
            Console.ReadLine();
        }
    }
}
