using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [Table("Departments")]
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required]
        [Column("Department Name,varchar")]
        [Length(3,50)]
        public string? Name { get; set; }
        public int Ins_ID { get; set; }


        // public DateTime HiringDate { get; set; } //بتجيب التوقيت بتاع دلوقتي
        [DataType(DataType.DateTime)]
        public string? HiringDate { get; set; }
    }
}
