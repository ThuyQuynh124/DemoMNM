using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoNetCore.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public String PersonID { get; set; }
        public string PersonName { get; set; }
    }
}