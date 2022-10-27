using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using CoreWebAppWithoutMVCFolder.Models;

namespace CoreWebAppWithoutMVCFolder.Repository
{
    public class EmployeeDapperContext
    {
        private IConfiguration _configuration;
        public EmployeeDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Models.EmployeeModel> GetAllTheEmployees()
        {
            string connstring = _configuration.GetConnectionString("SqlCon");
            SqlConnection con = new SqlConnection(connstring);
            var result = con.Query<EmployeeModel>("sp_Employee",commandType:System.Data.CommandType.StoredProcedure).ToList();
            return result;
        }
    }
}
