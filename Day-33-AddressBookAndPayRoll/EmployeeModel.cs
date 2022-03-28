using System;
using System.Collections.Generic;
using System.Text;

namespace Day_33_AddressBookAndPayRoll
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public float BasicPay { get; set; }
        public float Deductions { get; set; }
        public float TaxablePay { get; set; }
        public float Tax { get; set; }
        public float NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}