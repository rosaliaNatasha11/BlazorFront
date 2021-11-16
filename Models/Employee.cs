using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFront.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string PhotoPath { get; set; }
    }
    public enum Gender{
        Male,Female
    }
}
