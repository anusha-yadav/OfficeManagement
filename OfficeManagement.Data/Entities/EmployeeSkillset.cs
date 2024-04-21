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
    /// EmployeeSkillset
    /// </summary>
    public class EmployeeSkillset
    {
        /// <summary>
        /// EmployeeSkillsetId
        /// </summary>
        [Key]
        public int EmployeeSkillsetId { get; set; }

        /// <summary>
        /// EmployeeId
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// SkillsetId
        /// </summary>
        public int SkillsetId { get; set; }
    }
}
