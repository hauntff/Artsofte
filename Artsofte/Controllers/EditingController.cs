using Artsofte.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Artsofte.Controllers
{
    
    public class EditingController : Controller
    {
        private readonly ArtsofteDBDataContext _db = new ArtsofteDBDataContext();
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=test_database;Integrated Security=True";
        public ActionResult Edit(int employee_id)
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select * " +
                    "from [test_database].[dbo].[Employees_info] where id = " + employee_id, connection);
                connection.Open();

                var dr = command.ExecuteReader();

                while (dr.Read())
                {
                    employeeInfoModel.EmployeeID = (int)dr["id"];
                    employeeInfoModel.Name = dr["Name"].ToString();
                    employeeInfoModel.Surname = dr["Surname"].ToString();
                    employeeInfoModel.Age = (int)dr["Age"];
                    employeeInfoModel.DepartmentId = departments
                        .Where(x=>x.id == (int)dr["Department"])
                        .Select(x=>x.id)
                        .First();
                    employeeInfoModel.ProgrammingLanguageId = programmingLanguages
                        .Where(x=>x.id == (int)dr["Programming_language"])
                        .Select(x=>x.id)
                        .First();
                }
                connection.Close();
            }
            return View(employeeInfoModel);
        }

        // POST: Editing/Edit/5
        [HttpPost]
        public JsonResult Save(int employee_id,string name, string surname, int age,
            int department_id, int programming_language_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command =
                        new SqlCommand("EXEC editEmployee @id, @name, @surname, @age, @department, @programming_language", connection);
                    command.Parameters.AddWithValue("@id", employee_id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@department", department_id);
                    command.Parameters.AddWithValue("@programming_language", programming_language_id);

                    var dr = command.ExecuteScalar();
                    connection.Close();
                }

                return Json("Employee was edited successfully");
            }
            catch
            {
                return Json("ERROR!");
            }
        }

        
    }
}
