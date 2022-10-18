using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollSystem
{
    public class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; } 
        public string City { get; set; }
        public string State { get; set; } 
        public string Department { get; set; }  
        public string Gender { get; set; }


        public EmployeeDetails(int employeeID, string employeeName, long phoneNumber, string address, string city, string state, string department, string gender)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            State = state;
            Department = department;
            Gender = gender;    
        }
    }
}
