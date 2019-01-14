using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cars_And_Parts_Site_First_Performance.Models
{
    public class Cars_And_Parts_Site_First_PerformanceContext : DbContext
    {
        public Cars_And_Parts_Site_First_PerformanceContext (DbContextOptions<Cars_And_Parts_Site_First_PerformanceContext> options)
            : base(options)
        {
        }

        public DbSet<Cars_And_Parts_Site_First_Performance.Models.DepartmentModel> DepartmentModel { get; set; }
    }
}
