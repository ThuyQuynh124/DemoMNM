using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoNetCore.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]

        public String StudenID { get; set; }
        public string StudentName { get; set; }
        public string Address { get; set; } 
    }
}