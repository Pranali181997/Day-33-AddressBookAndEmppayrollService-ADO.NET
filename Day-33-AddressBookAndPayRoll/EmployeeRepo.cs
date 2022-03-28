using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_33_AddressBookAndPayRoll
{
    public class EmployeeRepo
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service1;Integrated Security=True";
        public bool DataBaseConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                DateTime now = DateTime.Now;
                connection.Open();
                using (connection)
                {
                    Console.WriteLine($"Connection is created Successful {now}");

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }

        public bool AddData(string employeeName, double basicPay)
        {
            return true;
        }

        public static void CreateTables()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                SqlCommand cmd = new SqlCommand("create table payroll_service(EmployeeId int identity(1,1),EmployeeName varchar(20),PhoneNumber varchar(10) NOT NULL, Address varchar(20) NOT NULL, Department varchar(20) NOT NULL, Gender char(1) NOT NULL, BasicPay float NOT NULL,Deductions float NOT NULL, TaxablePay float NOT NULL, Tax float  NOT NULL, NetPay float NOT NULL,StartDate DATETIME DEFAULT GETDATE(), City varchar(10) DEFAULT 'Pune', Country varchar(10) DEFAULT 'IN');", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Payroll table has been created successfully!");
                connection.Close();
            }
            
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
        public bool AddData(EmployeeModel model)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                using (connection)
                {
                    SqlCommand cmd = new SqlCommand("SP_AdDData", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@City", model.City);                  
                    cmd.Parameters.AddWithValue("@Country", model.Country);                  
                    cmd.Parameters.AddWithValue("@Deduction", model.Deductions);
                    cmd.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    cmd.Parameters.AddWithValue("@Tax", model.Tax);
                    cmd.Parameters.AddWithValue("@NetPay", model.NetPay);
                    cmd.Parameters.AddWithValue("@Department", model.Department);
                    cmd.Parameters.AddWithValue("@StartDate", DateTime.Now);
                    connection.Open();
                    var result = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
            return false;
        }
    }
}
