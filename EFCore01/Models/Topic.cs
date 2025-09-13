using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [Table("Topics")]
    internal class Topic
    {
        [Key]
        public int TopID { get; set; }
        public string? Name { get; set; }
    }
}
