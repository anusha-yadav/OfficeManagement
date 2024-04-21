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
    /// Skillset
    /// </summary>
    public class Skillset
    {
        /// <summary>
        /// SkillsetId
        /// </summary>
        [Key]
        public int SkillsetId { get; set; }

        /// <summary>
        /// SkillsetName
        /// </summary>
        public string? SkillsetName { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Department
        /// </summary>
        [ForeignKey("DepartmentId")]
        public virtual Department? Department { get; set; }
    }
}
