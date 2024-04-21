using OfficeManagement.Common.ViewModels;
using OfficeManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository.Contracts
{
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        List<SkillsetViewModel> GetSkillsets(int departmentId);
    }
}
