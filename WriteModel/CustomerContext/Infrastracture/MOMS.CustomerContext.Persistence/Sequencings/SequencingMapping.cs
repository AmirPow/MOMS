using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOMS.CustomerContext.Domain.Customers;
using MOMS.CustomerContext.Domain.Sequencings;
using System.Data;

namespace MOMS.CustomerContext.Persistence.Sequencings.Mappings
{
    public class SequencingMapping : EntityMappingBase<Sequencing>
    {
        public override void Configure(EntityTypeBuilder<Sequencing> builder)
        {
            Initial(builder);
            builder.Property(a=>a.CustomerId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.DoctorId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.TherapistId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.SubmitDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            builder.Property(a => a.TurnDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            builder.HasOne<Customer>().WithMany().HasForeignKey(e => e.CustomerId).IsRequired();
        }
    }
}
