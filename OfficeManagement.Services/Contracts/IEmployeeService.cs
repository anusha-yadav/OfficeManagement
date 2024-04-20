﻿using OfficeManagement.Common.ViewModels;
using OfficeManagement.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement.Services.Contracts
{
    public interface IEmployeeService 
    {
        void SaveDetails(EmployeeViewModel employeeDetailsModel);
        void DeleteEmployee(int employeeId);
        void GetAllEmployees();
    }
}
