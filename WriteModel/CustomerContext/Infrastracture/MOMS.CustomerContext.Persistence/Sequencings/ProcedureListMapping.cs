using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.CustomerContext.Domain.Sequencings;
using System.Data;

namespace MOMS.CustomerContext.Persistence.Sequencings.Mappings
{
    public class ProcedureListMapping : EntityMappingBase<ProcedureList>
    {
        public override void Configure(EntityTypeBuilder<ProcedureList> builder)
        {
            Initial(builder);
            builder.Property(a=>a.SequencingId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.ProcedureId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.HasOne<Sequencing>().WithMany(a => a.ProcedureLists).HasForeignKey(x => x.SequencingId).IsRequired();
        }
    }
}
