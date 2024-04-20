using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Data.Entities
{
    public class Department
    {
        [Key] 
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

        [InverseProperty("Department")]
        public virtual ICollection<Skillset> Skillsets { get; set; } = new List<Skillset>();

    }
}
