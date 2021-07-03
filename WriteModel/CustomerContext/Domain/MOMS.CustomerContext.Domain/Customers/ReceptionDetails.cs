using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class ReceptionDetails :EntityBase
    {
        public ReceptionDetails(Guid receptionId , Guid procedureId)
        {
            ReceptionId = receptionId;
            ProcedureId = procedureId;
        }
        public Guid ReceptionId { get; set; }
        public Guid ProcedureId { get; set; }
    }
}
