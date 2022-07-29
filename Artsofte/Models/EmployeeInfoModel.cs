using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Artsofte.Models
{
    public class EmployeeInfoModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<spr_department> Department { get; set; }
        public List<spr_programming_language> Programming_Language { get; set; }
        public int DepartmentId { get; set; }
        public int ProgrammingLanguageId { get; set; }
    }
}