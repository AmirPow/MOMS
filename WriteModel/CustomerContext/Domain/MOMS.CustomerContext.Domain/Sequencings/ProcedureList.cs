using Framework.Domain;
using System;

namespace MOMS.CustomerContext.Domain.Sequencings
{
    
    public class ProcedureList : EntityBase
    {
        public ProcedureList(Guid sequencingId , Guid procedureId)
        {
            SequencingId = sequencingId;
            ProcedureId = procedureId;
        }

        public Guid SequencingId { get; set; }
        public Guid ProcedureId { get; set; }
    }
}
