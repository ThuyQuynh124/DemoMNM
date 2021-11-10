using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoNetCore.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public String ProductID { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; } 
        public int Quantity { get; set; }
    }
}
