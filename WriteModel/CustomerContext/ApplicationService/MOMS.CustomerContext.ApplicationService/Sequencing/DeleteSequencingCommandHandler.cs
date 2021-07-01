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
    public class DeleteSequencingCommandHandler : ICommandHandler<DeleteSequencingCommand>
    {
        private readonly ISequencingRepository sequencingRepository;

        public DeleteSequencingCommandHandler(ISequencingRepository sequencingRepository)
        {
            this.sequencingRepository = sequencingRepository;
        }
        public void Execute(DeleteSequencingCommand command)
        {
            var  sequencing =sequencingRepository.GetBySequencingId(command.SequencingId);
            sequencingRepository.DeleteSequencing(sequencing);
        }
    }
}
