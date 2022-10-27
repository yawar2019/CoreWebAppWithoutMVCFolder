using CoreWebAppWithoutMVCFolder.Models;
using CoreWebAppWithoutMVCFolder.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppWithoutMVCFolder.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment _env;
        IConfiguration _configuration;
        IEmployeeRepository _employeeRepository;
        public HomeController(IWebHostEnvironment env,IConfiguration configuration,IEmployeeRepository employeeRepository)
        {
            _env = env;
            _configuration = configuration;
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            //var enviromentName = _env.EnvironmentName;
            //Console.WriteLine(enviromentName);
            //if (enviromentName == "Development")
            //{
            //    Console.WriteLine(enviromentName);
            //    return Content(enviromentName);
            //}


            // var AdminName = _configuration.GetValue<string>("AdminName");
            //var connectionstring = _configuration.GetConnectionString("sqlCon");
            //var readEmployee = "Manager is "+_configuration.GetSection("Employees")["Manager"];
            // var countOfEmployees = _configuration.GetValue<int>("Number_Of_Employees");  
            var readEmployee = "Manager is " + _configuration.GetSection("Employees");
            return Content(readEmployee[0].ToString());
        }

        public IActionResult GetAllEmployees()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Keerti";
            emp.EmpSalary = 21000;

            return View(emp);
        }

        public IActionResult GetAllTheEmployees()
        {
           return View(_employeeRepository.GetAllTheEmployees());
        }
    }
}
