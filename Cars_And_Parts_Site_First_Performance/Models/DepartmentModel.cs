using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars_And_Parts_Site_First_Performance.Models
{
    public class DepartmentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Brand> Brand { get; set; } = new List<Brand>();
        public ICollection<Accessory> Accessories { get; set; } = new List<Accessory>();
        public ICollection<Full_Stock_Car> Full_Stock_Cars { get; set; } = new List<Full_Stock_Car>();

        public DepartmentModel()
        {
        }

        public DepartmentModel(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public void AddBrad(Brand B)
        {
            Brand.Add(B);
        }

        public void RemoveBrand(Brand B)
        {
            Brand.Remove(B);
        }

        public void AddAccessory(Accessory Ac)
        {
            Accessories.Add(Ac);
        }

        public void RemoveAccessory(Accessory Ac)
        {
            Accessories.Remove(Ac);
        }

        public void AddFullStockCar(Full_Stock_Car FSC)
        {
            Full_Stock_Cars.Add(FSC);
        }

        public void RemoveFullStockCar(Full_Stock_Car FSC)
        {
            Full_Stock_Cars.Remove(FSC);
        }
    }
}
