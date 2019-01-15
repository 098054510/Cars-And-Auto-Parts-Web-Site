using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_And_Parts_Site_First_Performance.Models
{
    public class Accessory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DepartmentModel Department { get; set; }

        public Accessory()
        {
        }

        public Accessory(int ID, string Name, double Price, DepartmentModel Department)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Department = Department;
        }
    }
}
