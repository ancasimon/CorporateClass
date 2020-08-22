using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyA = new Company("Company A", new DateTime(2020, 07, 01));

            var employee1 = new Employee("Anna B", "receptionist", new DateTime(2020, 07, 01));
            var employee2 = new Employee("Georgie S", "CEO", new DateTime(2020, 07, 01));
            var employee3 = new Employee("Carlee N", "manager", new DateTime(2020, 07, 03));

            List<Employee> firstEmployees = new List<Employee>();
            firstEmployees.Add(employee1);
            firstEmployees.Add(employee2);
            firstEmployees.Add(employee3);

            companyA.Employees = firstEmployees;

            companyA.ListEmployees(companyA.Employees);
        }
    }
}
