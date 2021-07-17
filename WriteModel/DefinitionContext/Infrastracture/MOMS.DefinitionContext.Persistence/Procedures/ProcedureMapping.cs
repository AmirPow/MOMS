using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.DefinitionContext.Domain.Procedures;
using System.Data;

namespace MOMS.DefinitionContext.Persistence.Procedures
{
    public class ProcedureMapping : EntityMappingBase<Procedure>
    {
        public override void Configure(EntityTypeBuilder<Procedure> builder)
        {
            Initial(builder);
            builder.Property(a => a.Name).HasMaxLength(250).IsRequired();
            builder.Property(a => a.Price).HasColumnType(SqlDbType.Int.ToString()).IsRequired();
        }
    }
}
