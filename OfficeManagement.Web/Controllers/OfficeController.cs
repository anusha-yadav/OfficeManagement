using Microsoft.AspNetCore.Mvc;
using OfficeManagement.Common.ViewModels;
using OfficeManagement.Repository.Contracts;
using OfficeManagement.Services.Contracts;
using OfficeManagement.Services.Implementation;

namespace OfficeManagement.Web.Controllers
{
    public class OfficeController : Controller
    {
        private readonly IEmployeeService EmployeeService;

        public OfficeController(IEmployeeService employeeService) 
        {
            EmployeeService = employeeService;
            
        }
        public IActionResult Index()
        {
            return View();
        }

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

        public void SaveDetails(EmployeeViewModel employee)
        {
            EmployeeService.SaveDetails(employee);
        }
    }
}
