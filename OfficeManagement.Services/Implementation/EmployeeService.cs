using Microsoft.Extensions.Logging;
using OfficeManagement.Common.ViewModels;
using OfficeManagement.Repository.Contracts;
using OfficeManagement.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository EmployeeRepository;
        private readonly IUnitofWork UnitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitofWork unitOfWork)
        {
            EmployeeRepository = employeeRepository;
            UnitOfWork = unitOfWork;
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

    }
}
