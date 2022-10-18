using EmployeePayRollSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollSystem
{

    public class EmployeePayRollOperation
    {
        List<EmployeeDetails> listofemployeeDetails = new List<EmployeeDetails>();

        public void AddEmployeeToPayRoll(List<EmployeeDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added " + employeeData.EmployeeName);
                this.AddEmployeeToPayRoll(employeeData);
                Console.WriteLine("Employee Added " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.listofemployeeDetails);
        }

        private void AddEmployeeToPayRoll(EmployeeDetails employeeDetails)
        {
            listofemployeeDetails.Add(employeeDetails);
        }

        public void AddEmployeeToPayRollWithThread(List<EmployeeDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee Being Added " + employeeData.EmployeeName);
                    this.AddEmployeeToPayRoll(employeeData);
                    Console.WriteLine("Employee Added " + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.listofemployeeDetails);
        }
    }
}