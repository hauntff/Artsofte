using Artsofte.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artsofte.Controllers
{
    [RoutePrefix("/")]
    public class HomeController : Controller
    {
        private readonly ArtsofteDBDataContext _db = new ArtsofteDBDataContext();
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test_database;Integrated Security=True";
        [Route]
        public ActionResult Index()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("EXEC selectEmployees", connection);
                connection.Open();

                var dr = command.ExecuteReader();
                List<EmployeesInfo> employees = new List<EmployeesInfo>();
                while (dr.Read())
                {
                    EmployeesInfo employeeInfo = new EmployeesInfo();
                    employeeInfo.EmployeeID = (int)dr["id"];
                    employeeInfo.Name = dr["Name"].ToString();
                    employeeInfo.Surname = dr["Surname"].ToString();
                    employeeInfo.Age = (int)dr["Age"];
                    employeeInfo.Department = dr["department_name"].ToString();
                    employeeInfo.Programming_language = dr["PL_name"].ToString();
                    employees.Add(employeeInfo);
                }
                connection.Close();
                ViewData["employees"] = employees;
            }
            return View();
        }

        
    }

}