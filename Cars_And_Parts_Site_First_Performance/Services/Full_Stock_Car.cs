using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_And_Parts_Site_First_Performance.Models
{
    public class Full_Stock_Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double BasePrice { get; set; }
        public DepartmentModel Department { get; set; }

        public Full_Stock_Car()
        {
        }

        public Full_Stock_Car(int ID, string Model, int Year, double BasePrice, DepartmentModel Department)
        {
            this.ID = ID;
            this.Model = Model;
            this.Year = Year;
            this.BasePrice = BasePrice;
            this.Department = Department;
        }
    }
}
