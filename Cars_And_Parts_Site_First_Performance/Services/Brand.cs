using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_And_Parts_Site_First_Performance.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DepartmentModel Department { get; set; }

        public Brand()
        {
        }

        public Brand(int ID, string Name, string Country, DepartmentModel Department)
        {
            this.ID = ID;
            this.Name = Name;
            this.Country = Country;
            this.Department = Department;
        }
    }
}
