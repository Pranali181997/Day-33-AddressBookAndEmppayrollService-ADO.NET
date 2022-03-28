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
        [Test]
        public void checkForInsertedData()
        {
            string EmployeeName = "Terisa";
            double BasicPay = 3000000;
            EmployeeRepo employeeRepository = new EmployeeRepo(); //create object EmployeeRepository class
            bool actual = employeeRepository.AddData(EmployeeName, BasicPay); //call method and pass parameter
            bool expected = true; //expected true 
            Assert.AreEqual(expected, actual); // Check equal or not
        }
    }
}