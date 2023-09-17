using EmployeeHomework.Data;
using EmployeeHomework.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeHomework.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeHomeworkDbContext employeeHomeworkDbContext;

        public EmployeeController(EmployeeHomeworkDbContext employeeHomeworkDbContext)
        {
            this.employeeHomeworkDbContext = employeeHomeworkDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(Employee employee)
        {
            var employees = new Employee
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Title = employee.Title,
            };

            employeeHomeworkDbContext.Employees.Add(employees);
            employeeHomeworkDbContext.SaveChanges();

            return View("Add");
        }
    }
}
