using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees --> so initially, this was a private property; 
        //private List<Employee> Employees { get; set; }

        //then #2 in the ex requires that you make changes to allow users to assign employees to the company --> so: 
        public List<Employee> Employees { get; set;}


        // Create a method that allows a caller to add an employee
        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        // Create a method that allows a caller to remove an employee
        public void RemoveEmployee(Employee currentEmployee)
        {
            Employees.Remove(currentEmployee);
        }

        // Create a method that allows a caller to retrieve the list of employees
        public void ListEmployees(List<Employee> listOfEmployees)
        {
            Console.WriteLine("Our current employees are: ");
            foreach (var person in listOfEmployees)
            {
                Console.WriteLine(person.Name);
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }
    }
}
