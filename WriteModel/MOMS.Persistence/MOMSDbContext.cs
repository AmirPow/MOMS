using Framework.AssemblyHelper;
using Framework.Core.Persistence;
using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MOMS.Persistence
{
    public class MOMSDbContext :DbContextBase
    {
        public MOMSDbContext(DbContextOptions<MOMSDbContext> dbContextOptions): base(dbContextOptions)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var entityMapping = DetectEntityMapping();
            entityMapping.ForEach(a => { builder.ApplyConfiguration(a); });
            base.OnModelCreating(builder);
        }

        protected List<dynamic> DetectEntityMapping()
        {
            var assemblyHelper = new AssemblyDiscovery("MOMS*.dll");
            var getType = assemblyHelper.DiscoverTypes<IEntityMapping>("MOMS")
                .Select(Activator.CreateInstance)
                .Cast<dynamic>().ToList();
            return getType;
        }
    }
}
