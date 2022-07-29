using Artsofte.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artsofte.Controllers
{
    [RoutePrefix("/add")]
    public class AddingController : Controller
    {
        private readonly ArtsofteDBDataContext _db = new ArtsofteDBDataContext();
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test_database;Integrated Security=True";
        public ActionResult Add()
        {
            EmployeeInfoModel employeeInfoModel = new EmployeeInfoModel();

            var programmingLanguages = _db.spr_programming_languages.ToList();
            programmingLanguages.Add(new spr_programming_language()
            {
                id = 0,
                PL_name = "Choose a department"
            });
            var departments = _db.spr_departments.ToList();
            departments.Add(new spr_department()
            {
                id = 0,
                department_name = "Choose a department"
            });
            employeeInfoModel.Programming_Language = programmingLanguages.OrderBy(x => x.id).ToList();
            employeeInfoModel.Department = departments.OrderBy(x => x.id).ToList();
            return PartialView(employeeInfoModel);
        }

        [HttpPost]
        public JsonResult AddEmployee(string name, string surname, int age,
            int department_id, int programming_language_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command =
                        new SqlCommand("EXEC insertEmployee @name, @surname, @age, @department, @programming_language", connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@department", department_id);
                    command.Parameters.AddWithValue("@programming_language", programming_language_id);

                    var dr = command.ExecuteScalar();
                    connection.Close();
                }
                return Json("Employee was added successfully", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("ERROR!", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult DeleteEmployee(int employee_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command =
                        new SqlCommand("EXEC deleteEmployee @id", connection);
                    command.Parameters.AddWithValue("@id", employee_id);
                    var dr = command.ExecuteScalar();
                    connection.Close();
                }
                return Json("Employee was deleted successfully", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("ERROR!", JsonRequestBehavior.AllowGet);
            }
        }

        
    }

}
