using Day_33_AddressBookAndPayRoll;
using NUnit.Framework;


namespace NUnitTest_Payroll_service
{
     public class Tests
        {
            [SetUp]
            public void Setup()
            {
            }
            [Test]
            public void CheckConnection() //Create CheckConnection method to Check Connection
            {
                EmployeeRepo employeeRepository = new EmployeeRepo(); 
                bool actual = employeeRepository.DataBaseConnection(); 
                bool expected = true; 
                Assert.AreEqual(expected, actual);
            }
        }
    }