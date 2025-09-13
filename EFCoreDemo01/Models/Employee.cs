using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo01.Models
{
    // Model -- Entity -- Domain Model -- POCO Class [Plain Old CLR Objects]
    // Properties Only



    #region By Convention
    //// By Convention
    //internal class Employee
    //{
    //    // Public Numeric Property Names as [Id - EmployeeId] => Primary Key
    //    // Automatically assumed as Primary Key
    //    // Id Mapped to int pk with identity constraint (1, 1)
    //    public int Id { get; set; }

    //    // Nullable Reference Type
    //    // Stirng? is mapped to nvarchar(max), and will Allow Null 
    //    public string? EmpName { get; set; }

    //    // Value Type
    //    // Not Allow Null
    //    // decimal will mapped as decimal(18, 2)
    //    public decimal Salary { get; set; }

    //    // Value Type
    //    // int is mapped as int
    //    // not allow null
    //    public int Age { get; set; }
    //} 
    #endregion



    //================================================================



    #region Data Annotation
    //[Table("Hamada")]
    [Table("Employee")]
    internal class Employee
    {
        // Public Numeric Property Names as [Id - EmployeeId] => Primary Key
        // Automatically assumed as Primary Key
        // Id Mapped to int pk with identity constraint (1, 1)
        [Key]
        public int EmpId { get; set; }

        // Nullable Reference Type
        // Stirng? is mapped to nvarchar(max), and will Allow Null 
        [Required]
        [Column("EmployeeName", TypeName = "varchar")]
        //[MaxLength(50, ErrorMessage = "Name of Employee Must be Less Than 51 Char")]
        //[MinLength(3, ErrorMessage = "Name of Employee Must be more Than 3 Char")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name of Employee Must be between 3 ~ 51 Char")]
        //[Length(3, 50)]
        public string EmpName { get; set; }

        // Value Type
        // Not Allow Null
        // decimal will mapped as decimal(18, 2)
        [Column("EmployeeSalary", TypeName = "decimal(10, 2)")]

        public decimal Salary { get; set; }

        // Value Type
        // int is mapped as int
        // not allow null
        [Range(25, 40)]
        //[AllowNull]
        [AllowedValues(25,30,35,40)]
        [DeniedValues(25,30,35,40)]
        public int Age { get; set; }

        [Phone] // check value before store in DB
        [DataType(DataType.PhoneNumber)] // To Display Value as a Phone Number
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress] // check value before store in DB
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [NotMapped]
        public int Deduction { get; set; }
    }
    #endregion



    //================================================================

}
