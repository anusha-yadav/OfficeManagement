using Microsoft.AspNetCore.Mvc;
using OfficeManagement.Common.ViewModels;
using OfficeManagement.Repository.Contracts;
using OfficeManagement.Services.Contracts;
using OfficeManagement.Services.Implementation;

namespace OfficeManagement.Web.Controllers
{
    /// <summary>
    /// OfficeController
    /// </summary>
    public class OfficeController : Controller
    {
        private readonly IEmployeeService EmployeeService;

        /// <summary>
        /// OfficeController
        /// </summary>
        /// <param name="employeeService"></param>
        public OfficeController(IEmployeeService employeeService) 
        {
            EmployeeService = employeeService;
            
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// AddEmployeeDialog
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public PartialViewResult AddEmployeeDialog(int employeeId)
        {
            EmployeeViewModel employee = new EmployeeViewModel();
            try
            {
                employee = new EmployeeViewModel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return PartialView("AddOrEditEmployee", employee);
        }

        /// <summary>
        /// SaveDetails
        /// </summary>
        /// <param name="employee"></param>
        public void SaveDetails(EmployeeViewModel employee)
        {
            EmployeeService.SaveDetails(employee);
        }
    }
}
