using EmployeePayRollSystem;

namespace EmployeeSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Given10EmployeeWhenAddedToListShouldMatchEmpEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

            employeeDetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Rita", phoneNumber: 8904567890, address: "11 streets", city: "Pune", state: "Maharashtra", department: "HR", gender: "F"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 2, employeeName: "Sam", phoneNumber: 9004567890, address: "12 streets", city: "Bombay", state: "Maharashtra", department: "Finance", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 3, employeeName: "Piyu", phoneNumber: 1234567890, address: "13 streets", city: "Indore", state: "Madhya Pradesh", department: "HR", gender: "F" ));
            employeeDetails.Add(new EmployeeDetails(employeeID: 4, employeeName: "Roe", phoneNumber: 9234567890, address: "14 streets", city: "Bhopal", state: "Madhya Pradesh", department: "Manager", gender: "M" ));
            employeeDetails.Add(new EmployeeDetails(employeeID: 5, employeeName: "Ajay", phoneNumber: 9934567890, address: "streets", city: "Pune", state: "Maharashtra", department: "HR", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 6, employeeName: "Vijay", phoneNumber: 8834567890, address: "15 streets", city: "Lucknow", state: "Uttar Pradesh", department: "Marketing", gender: "M"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 7, employeeName: "Maya", phoneNumber: 9898567890, address: "16 streets", city: "Jaipur", state: "Rajasthan", department: "HR", gender: "F"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 8, employeeName: "Payal", phoneNumber: 8984567890, address: " streets A", city: "Ujjan", state: "Madhya Pradesh", department: "Marketing", gender: "F"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 9, employeeName: "Ruhi", phoneNumber: 7878567890, address: " streets B", city: "Udaipur", state: "Rajasthan", department: "Finance", gender: "F"));
            employeeDetails.Add(new EmployeeDetails(employeeID: 10, employeeName: "Amit", phoneNumber: 9090567890, address: " streets C", city: "Pune", state: "Maharashtra", department: "Manager", gender: "M"));


            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            DateTime startTime = DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayRoll(employeeDetails);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Duration without thread " + (endTime - startTime));

            DateTime threadtartTime = DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayRollWithThread(employeeDetails);
            DateTime threadendTime = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (threadendTime - threadtartTime));
        }
    }
}