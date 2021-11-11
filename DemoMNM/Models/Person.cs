using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoNetCore.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Display(Name="ID")]
        public String PersonID { get; set; }
        [Display(Name="Họ và tên")]
        public string PersonName { get; set; }
    }
}