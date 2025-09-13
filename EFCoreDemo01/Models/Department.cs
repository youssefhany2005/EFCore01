using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo01.Models
{
    internal class Department 
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
    }
}
