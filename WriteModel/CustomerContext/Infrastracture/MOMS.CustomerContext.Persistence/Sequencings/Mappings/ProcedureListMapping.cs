using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.CustomerContext.Domain.Sequencings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Persistence.Sequencings.Mappings
{
    public class ProcedureListMapping : EntityMappingBase<ProcedureList>
    {
        public override void Configure(EntityTypeBuilder<ProcedureList> builder)
        {
            builder.Property(a=>a.SequencingId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.ProcedureId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.HasOne<Sequencing>().WithMany(a => a.ProcedureLists).HasForeignKey(x => x.SequencingId).IsRequired();
        }
    }
}
