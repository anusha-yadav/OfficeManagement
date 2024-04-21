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
            int projectId = SaveProjectDetails(viewModel.ProjectName);
            employee.EmployeeName = viewModel.Name;
            employee.DepartmentId = viewModel.DepartmentId;
            employee.Experience = viewModel.Experience;
            employee.ProjectId = projectId;
            SaveSkillsets(viewModel);
            Context.Add(employee);
            SaveChanges();
        }

        private int SaveProjectDetails(string  projectName)
        {
            var project = Context.Projects.Where(x=>x.ProjectName.ToLower() == projectName.ToLower()).FirstOrDefault();
            if(project == null)
            {
                project = new();
            }
            project.ProjectName = projectName;
            if(project == null)
            {
                Context.Projects.Add(project);
                Context.SaveChanges();
            }
            return project.ProjectId;
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
            Context.EmployeeSkills.AddRange(employeeSkillset);
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
