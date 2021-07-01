using Framework.Core.ApplicationService;
using System;
using System.Collections.Generic;
namespace MOMS.CustomerContext.ApplicationServiceContracts.Sequencing
{
    public class CreateSequencingCommand :Command
    {
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime TurnDateTime { get; set; }
        public List<Guid> ProcedureLists { get; set; }
    }
}
