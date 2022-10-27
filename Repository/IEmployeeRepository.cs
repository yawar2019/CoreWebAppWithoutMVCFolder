using CoreWebAppWithoutMVCFolder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppWithoutMVCFolder.Repository
{
   public interface IEmployeeRepository
    {
        List<EmployeeModel> GetAllTheEmployees();
    }
}
