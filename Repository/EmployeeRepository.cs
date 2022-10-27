using CoreWebAppWithoutMVCFolder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppWithoutMVCFolder.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public EmployeeDapperContext _employeeDapperContext;
        public EmployeeRepository(EmployeeDapperContext employeeDapperContext)
        {
            _employeeDapperContext = employeeDapperContext;
        }
        public List<EmployeeModel> GetAllTheEmployees()
        {
           return  _employeeDapperContext.GetAllTheEmployees();
        }
    }
}
