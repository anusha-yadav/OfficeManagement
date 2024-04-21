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
    /// Projects
    /// </summary>
    public class Projects
    {
        /// <summary>
        /// ProjectId
        /// </summary>
        [Key] 
        public int ProjectId { get; set; }

        /// <summary>
        /// ProjectName
        /// </summary>
        public string? ProjectName { get; set; }

        /// <summary>
        /// Employees
        /// </summary>
        [InverseProperty("Project")]
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
