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
    /// Department
    /// </summary>
    public class Department
    {
        /// <summary>
        /// DepartmentId
        /// </summary>
        [Key] 
        public int DepartmentId { get; set; }

        /// <summary>
        /// DepartmentName
        /// </summary>
        public string? DepartmentName { get; set; }

        /// <summary>
        /// Employees
        /// </summary>

        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        /// <summary>
        /// Skillsets
        /// </summary>
        [InverseProperty("Department")]
        public virtual ICollection<Skillset> Skillsets { get; set; } = new List<Skillset>();

    }
}
