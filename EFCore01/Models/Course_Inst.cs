using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [Table("Course_Inst")]
    internal class Course_Inst
    {
        [Key]
        public int InsId { get; set; }
        public int Course_ID { get; set; }
        public int evaluate { get; set; }
    }
}
