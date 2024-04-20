using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Data.Entities
{
    public class EmployeeSkillset
    {
        [Key]
        public int EmployeeSkillsetId { get; set; }
        public int EmployeeId { get; set; }
        public int SkillsetId { get; set; }
    }
}
