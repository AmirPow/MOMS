using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.Persistence
{
    public class TMSDesignTimeDbContext : IDesignTimeDbContextFactory<MOMSDbContext>
    {
        public MOMSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MOMSDbContext>();

            optionsBuilder.UseSqlServer("data source= 185.55.224.3 ;Initial Catalog=dahriman_MOMS  ;User Id=dahriman_AdminUser ;password=@N379645099_A_M ;");
            return new MOMSDbContext(optionsBuilder.Options);
        }
    }
}
