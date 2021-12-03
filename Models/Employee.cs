using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFront.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Fisrt Name is required")]
        [StringLength(100,MinimumLength =2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        // public string ConfirmEmail{ get; set; }
        // [Compare("Email", ErrorMessage ="Password adn Compare must be the same")]
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
