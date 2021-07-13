using Framework.Domain;
using System;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class ReceptionDetails :EntityBase
    {
        protected ReceptionDetails()
        {

        }
        public ReceptionDetails(Guid receptionId , Guid procedureId)
        {
            ReceptionId = receptionId;
            ProcedureId = procedureId;
        }
        public Guid ReceptionId { get; set; }
        public Guid ProcedureId { get; set; }
    }
}
