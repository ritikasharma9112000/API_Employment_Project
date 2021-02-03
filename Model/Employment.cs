using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employment_Project.Model
{
    public class Employment
    {
        public int id { get; set; }
        public string Employer_name { get; set; }
        public string Address_of_employer { get; set; }
        public string Job_role { get; set; }
        public decimal Job_salary { get; set; }
        public string Job_type { get; set; }
    }
}
