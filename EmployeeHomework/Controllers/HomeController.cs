using EmployeeHomework.Data;
using EmployeeHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeeHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeHomeworkDbContext employeeHomeworkDbContext;

        public HomeController(EmployeeHomeworkDbContext employeeHomeworkDbContext)
        {
            this.employeeHomeworkDbContext = employeeHomeworkDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await employeeHomeworkDbContext.Employees.ToListAsync();

            return View(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Orders(int id)
        {
            

            return View();
        }
       
    }
}