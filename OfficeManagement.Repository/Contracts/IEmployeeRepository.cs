using OfficeManagement.Common.ViewModels;
using OfficeManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository.Contracts
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        public void SaveDetails(EmployeeViewModel viewModel);
        void DeleteEmployee(int employeeId);
        void GetAllEmployees();

    }
}
