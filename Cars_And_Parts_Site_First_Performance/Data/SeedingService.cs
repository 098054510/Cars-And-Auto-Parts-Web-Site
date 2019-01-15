using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars_And_Parts_Site_First_Performance.Models;

namespace Cars_And_Parts_Site_First_Performance.Data
{
    public class SeedingService
    {
        private Cars_And_Parts_Site_First_PerformanceContext _context;

        public SeedingService(Cars_And_Parts_Site_First_PerformanceContext context)
        {
            _context = context;
        }

        public void Seed() //Use this for add more cars, accessories and brands.
        {
            if (_context.Accessories.Any() ||
                _context.Brands.Any() ||
                _context.Full_Stock_Cars.Any())
            {
                return; // Case Return, the Database has been seeded.
            }

            DepartmentModel D1 = new DepartmentModel(1, "Brand");
            DepartmentModel D2 = new DepartmentModel(2, "Accessory");
            DepartmentModel D3 = new DepartmentModel(3, "Full Stock Car");

            Brand B1 = new Brand(1, "Volkswagen", "German", D1);
            Brand B2 = new Brand(2, "General Motors", "United States", D1);
            Brand B3 = new Brand(3, "Ford Motors Company", "United States", D1);
            Brand B4 = new Brand(4, "Fiat", "Italy", D1);

            Accessory A1 = new Accessory(1, "Turbo Kit with turbocompressor 50/48", 1500, D2);
            Accessory A2 = new Accessory(2, "Forged Piston and Rod kit", 1500, D2);
            Accessory A3 = new Accessory(3, "Ceramic Clutch", 600, D2);
            Accessory A4 = new Accessory(4, "Surge Tank", 800, D2);
            Accessory A8 = new Accessory(5, "Camshaft '49g'", 169, D2);

            Full_Stock_Car F1 = new Full_Stock_Car(1, "Gol 1.6 Plus", 1986, 5000, D3);
            Full_Stock_Car F2 = new Full_Stock_Car(2, "Opala Comodoro SL/E", 1988, 5890, D3);
            Full_Stock_Car F3 = new Full_Stock_Car(3, "F-150", 1982, 19000, D3);
            Full_Stock_Car F4 = new Full_Stock_Car(4, "Palio 1.6 ELX", 2010, 16000, D3);

            _context.DepartmentModel.AddRange(D1, D2, D3);
            _context.Brands.AddRange(B1, B2, B3, B4);
            _context.Accessories.AddRange(A1, A2, A3, A4, A8);
            _context.Full_Stock_Cars.AddRange(F1, F2, F3, F4);
            _context.SaveChanges();

        }
    }
}
