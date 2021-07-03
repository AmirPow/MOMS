using Framework.Core.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.ApplicationServiceContracts.Sequencing
{
    public class UpdateSequencingCommand :Command
    {
        public Guid SequencingId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime TurnDateTime { get; set; }
        public List<Guid> ProcedureLists { get; set; }
    }
}
