using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Data.Entities
{
    /// <summary>
    /// Employee
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// EmployeeId
        /// </summary>
        [Key]
        public int EmployeeId { get; set; }

        /// <summary>
        /// EmployeeName
        /// </summary>
        public string? EmployeeName { get; set; }

        /// <summary>
        /// Experience
        /// </summary>
        public decimal Experience { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// ProjectId
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// Department
        /// </summary>
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }

        /// <summary>
        /// Project
        /// </summary>
        [ForeignKey("ProjectId")]
        public virtual Projects? Project { get; set; }

    }
}
