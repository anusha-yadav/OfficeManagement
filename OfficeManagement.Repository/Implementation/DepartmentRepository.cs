using OfficeManagement.Common.ViewModels;
using OfficeManagement.Data.Entities;
using OfficeManagement.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository.Implementation
{
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private readonly OfficeDbContext Context;
        public DepartmentRepository(OfficeDbContext context) : base(context)
        {
            Context = context;
        }

        public List<SkillsetViewModel> GetSkillsets(int departmentId)
        {
            List<SkillsetViewModel> skillsets = new();
            skillsets = Context.Skillsets.Where(x=>x.DepartmentId == departmentId)
                                         .Select(x => new SkillsetViewModel
                                         {
                                             SkillsetId = x.SkillsetId,
                                             SkillsetName = x.SkillsetName
                                         }).ToList();
            return skillsets;
        }
    }
}
