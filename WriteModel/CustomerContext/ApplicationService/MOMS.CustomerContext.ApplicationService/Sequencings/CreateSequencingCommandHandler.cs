using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using MOMS.CustomerContext.Domain.Sequencings;

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
            //var sequencing = new Sequencing(command.CustomerId,
            //    command.DoctorId,
            //    command.TherapistId,
            //    command.TurnDateTime
            //    );
            //sequencing.AddProcedureList(command.ProcedureLists);
            //sequencingRepository.CreateSequencing(sequencing);
        }
    }
}
