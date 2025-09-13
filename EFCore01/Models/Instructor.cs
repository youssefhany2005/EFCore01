using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [Table("Instructors")]
    internal class Instructor
    {
        [Key]
        public int InsId { get; set; }
        public string? Name { get; set; }
        public decimal Bonus { get; set; }
        [Required]
        [Column("Instructor Salary",TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }

    }
}
