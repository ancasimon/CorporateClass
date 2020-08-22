using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, string jobTitle, DateTime startDate)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
