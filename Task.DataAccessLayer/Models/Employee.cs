using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Task.DataAccessLayer.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Job { get; set; }= string.Empty;
        [Required]
        [Range(0,100000)]
        public double Salary { get; set; }
        [Required]
        public byte[]? Photo { get; set; }= null;
        [NotMapped]
        public Image displayphoto { get; set; }

    }
}
