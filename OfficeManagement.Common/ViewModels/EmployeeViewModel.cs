using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Common.ViewModels
{
    /// <summary>
    /// EmployeeViewModel
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// EmployeeId
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Experience
        /// </summary>
        public decimal Experience { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// SkillsetIds
        /// </summary>
        public List<int>SkillsetIds { get; set; }

        /// <summary>
        /// DepartmentId
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// ProjectId
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// ProjectName
        /// </summary>
        public string? ProjectName { get; set; }
    }
}
