using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cars_And_Parts_Site_First_Performance.Models;

namespace Cars_And_Parts_Site_First_Performance.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<DepartmentModel> DPList = new List<DepartmentModel>();
            DPList.Add(new DepartmentModel { ID = 1, Name = "Accessory" });
            DPList.Add(new DepartmentModel { ID = 2, Name = "Brand" });
            DPList.Add(new DepartmentModel { ID = 3, Name = "Full Stock Car" });
            return View(DPList);
        }
    }
}