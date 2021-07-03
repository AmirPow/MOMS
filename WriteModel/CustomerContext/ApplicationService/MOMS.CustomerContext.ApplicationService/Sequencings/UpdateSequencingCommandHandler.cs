using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using MOMS.CustomerContext.Domain.Sequencings;

namespace MOMS.CustomerContext.ApplicationService.Sequencings
{
    public class UpdateSequencingCommandHandler : ICommandHandler<UpdateSequencingCommand>
    {
        private readonly ISequencingRepository sequencingRepository;

        public UpdateSequencingCommandHandler(ISequencingRepository sequencingRepository)
        {
            this.sequencingRepository = sequencingRepository;
        }
        public void Execute(UpdateSequencingCommand command)
        {
            var OldSequencing = sequencingRepository.GetBySequencingId(command.SequencingId);
            sequencingRepository.DeleteSequencing(OldSequencing);
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
