using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Artsofte.Models
{
    public class EmployeesInfo
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Programming_language { get; set; }
    }
}