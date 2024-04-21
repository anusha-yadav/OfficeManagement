using OfficeManagement.Common.Enums;
using OfficeManagement.Common.ViewModels;
using OfficeManagement.Repository.Contracts;
using OfficeManagement.Services.Contracts;
using System.Web.Mvc;

namespace OfficeManagement.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository EmployeeRepository;
        private readonly IDepartmentRepository DepartmentRepository;
        private readonly IUnitofWork UnitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitofWork unitOfWork, IDepartmentRepository departmentRepository)
        {
            EmployeeRepository = employeeRepository;
            UnitOfWork = unitOfWork;
            DepartmentRepository = departmentRepository;
        }

        public void SaveDetails(EmployeeViewModel employeeDetailsModel)
        {
            EmployeeRepository.SaveDetails(employeeDetailsModel);
            UnitOfWork.Save();
        }

        public void DeleteEmployee(int employeeId)
        {
            EmployeeRepository.DeleteEmployee(employeeId);
            UnitOfWork.Save();
        }

        public void GetAllEmployees()
        {
            var employees = EmployeeRepository.GetAll();
        }

        public IEnumerable<SelectListItem> GetDepartments()
        {
            return Enum.GetValues(typeof(DepartmentEnum))
                       .Cast<DepartmentEnum>()
                       .Select(level => new SelectListItem
                       {
                           Value = ((int)level).ToString(),
                           Text = level.ToString()
                       });
        }

        public List<SkillsetViewModel> GetSkillsets(int departmentId)
        {
            var skillsets = DepartmentRepository.GetSkillsets(departmentId);
            return skillsets;
        }
    }
}
