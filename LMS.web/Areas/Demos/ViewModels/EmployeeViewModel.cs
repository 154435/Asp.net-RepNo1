using System;
using System.ComponentModel.DataAnnotations;


namespace LMS.web.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "Employee ID")]
        [Required]
        public int ID { get; set; }

        [Display(Name = "Name of Employee")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MaxLength(80, ErrorMessage = "{0} can contain a maximum of {1} characters")]
        [MinLength(2, ErrorMessage = "{0} shoild contain a minimum of {1} characters")]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Range(minimum: 0, maximum: 200000,ErrorMessage = "{0} has to be between {1} and {2}")]
        public decimal Salary { get; set; } 

        public bool IsEnabled { get; set; }
    }
}
