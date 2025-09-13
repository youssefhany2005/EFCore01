using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        [Column("First Name,varchar")]
        [MaxLength(50,ErrorMessage ="Name Of Student Must Be Less Than 51 Characters")]
        [MinLength(3, ErrorMessage = "Name Of Student Must Be More Than 3 Characters")]
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        [Range(10,20)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
}
