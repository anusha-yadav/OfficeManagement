using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Data.Entities
{
    public class Projects
    {
        [Key] 
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        [InverseProperty("Project")]
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
