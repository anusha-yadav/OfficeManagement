using Microsoft.EntityFrameworkCore;
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
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly OfficeDbContext Context;
        public EmployeeRepository(OfficeDbContext context) : base(context)
        {
            Context = context;
        }

        /// <summary>
        /// SaveDetails
        /// </summary>
        /// <param name="viewModel"></param>
        public void SaveDetails(EmployeeViewModel viewModel)
        {
            Employee employee = GetById(viewModel.EmployeeId);
            if(employee == null)
            {
                 employee = new Employee();
            }
            employee.EmployeeName = viewModel.Name;
            employee.DepartmentId = viewModel.DepartmentId;
            employee.Experience = viewModel.Experience;
            employee.Email = viewModel.Email;
            employee.ProjectId = viewModel.ProjectId;
            SaveSkillsets(viewModel);
            SaveChanges();
        }

        private void SaveSkillsets(EmployeeViewModel employee)
        {
            var employeeSkillset = Context.EmployeeSkills.Where(x => x.EmployeeId == employee.EmployeeId).ToList();
            if(employeeSkillset == null)
            {
                employee.SkillsetIds.ForEach(x => new EmployeeSkillset
                {
                    SkillsetId = x,
                    EmployeeId = employee.EmployeeId,
                });
            }
            Context.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            Employee employee = GetById(employeeId);
            if(employee != null)
            {
                Delete(employee);
                SaveChanges();
            }
        }

        public void GetAllEmployees()
        {
            GetAll();
        }
    }
}
