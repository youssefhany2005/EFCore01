using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [Table("Stud_Course")]
    internal class Stud_Course
    {
        [Key]
        public int StdId { get; set; }
        public int Course_ID { get; set; }
        public int Grade { get; set; }
    }
}
