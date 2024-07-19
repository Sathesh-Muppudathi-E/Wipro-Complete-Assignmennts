


using Day17_Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities testempdb = new EmployeeDBEntities();
            List<Employee> employees = testempdb.Employees.ToList();
            List<Department> departments = testempdb.Departments.ToList();

            Employee emp = new Employee
            {
                EmployeeId = 1,
                EmployeeName = "sathish",
                Age = 23,
                Gender = "male",
                City = "chennai",
                Address = "Tamilnadu"
            };

            Employee emp1 = new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Lokesh",
                Age = 20,
                Gender = "male",
                City = "bnglr",
                Address = "bnglr"
            };

            Employee emp3 = new Employee
            {
                EmployeeId = 3,
                EmployeeName = "pradeep",
                Age = 29,
                Gender = "male",
                City = "hyd",
                Address = "hyd"
            };

            testempdb.Employees.Add(emp);
            testempdb.Employees.Add(emp1);
            testempdb.Employees.Add(emp3);

            Department dept = new Department
            {
                DeptName = "IT",
                DeptId = 1,
                DeptCreation = DateTime.Today
            };

            Department dept1 = new Department
            {
                DeptName = "HR",
                DeptId = 2,
                DeptCreation = DateTime.Today
            };

            Department dept2 = new Department
            {
                DeptName = "Development",
                DeptId = 3,
                DeptCreation = DateTime.Today
            };

            testempdb.Departments.Add(dept);
            testempdb.Departments.Add(dept1);
            testempdb.Departments.Add(dept2);

            testempdb.SaveChanges();
        }
    }
}



