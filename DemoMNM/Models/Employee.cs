using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoNetCore.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public String EmployeeID { get; set; }
        public string EmployName { get; set; }
        public string PhoneNumber { get; set; }
    }
}