using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
