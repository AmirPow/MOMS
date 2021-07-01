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
    public class SequencingMapping : EntityMappingBase<Sequencing>
    {
        public override void Configure(EntityTypeBuilder<Sequencing> builder)
        {
            builder.Property(a=>a.CustomerId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.DoctorId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.TherapistId).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            builder.Property(a => a.SubmitDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            builder.Property(a => a.TurnDateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();

        }
    }
}
