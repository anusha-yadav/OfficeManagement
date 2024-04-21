using OfficeManagement.Common.ViewModels;
using OfficeManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Repository.Contracts
{
    /// <summary>
    /// IEmployeeRepository
    /// </summary>
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        /// <summary>
        /// SaveDetails
        /// </summary>
        /// <param name="viewModel"></param>
        public void SaveDetails(EmployeeViewModel viewModel);

        /// <summary>
        /// DeleteEmployee
        /// </summary>
        /// <param name="employeeId"></param>
        void DeleteEmployee(int employeeId);

        /// <summary>
        /// GetAllEmployees
        /// </summary>
        void GetAllEmployees();

    }
}
