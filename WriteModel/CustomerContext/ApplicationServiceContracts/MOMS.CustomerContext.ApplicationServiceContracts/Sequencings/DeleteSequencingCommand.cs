using Framework.Core.ApplicationService;
using System;

namespace MOMS.CustomerContext.ApplicationServiceContracts.Sequencing
{
    public class DeleteSequencingCommand :Command
    {
        public Guid SequencingId { get; set; }
    }
}
