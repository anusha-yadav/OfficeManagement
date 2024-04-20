using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Common.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public decimal Experience { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public List<int>SkillsetIds { get; set; }
        public int DepartmentId { get; set; }
        public int ProjectId { get; set; }
        public List<string>? Skills {  get; set; } = new List<string>();
        public string? ProjectName { get; set; }
    }
}
