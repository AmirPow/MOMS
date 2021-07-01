using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using MOMS.CustomerContext.Domain.Sequencings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.ApplicationService.Sequencings
{
    public class CreateSequencingCommandHandler : ICommandHandler<CreateSequencingCommand>
    {
        private readonly ISequencingRepository sequencingRepository;

        public CreateSequencingCommandHandler(ISequencingRepository sequencingRepository)
        {
            this.sequencingRepository = sequencingRepository;
        }
        public void Execute(CreateSequencingCommand command)
        {
            var sequencing = new Sequencing(command.CustomerId,
                command.DoctorId,
                command.TherapistId,
                command.TurnDateTime
                );
            sequencing.AddProcedureList(command.ProcedureLists);
            sequencingRepository.CreateSequencing(sequencing);
        }
    }
}
