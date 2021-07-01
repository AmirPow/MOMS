using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using MOMS.CustomerContext.Facade.Contracts.Sequencings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Facade.Sequencings
{
    public class SequencingFacade : FacadeCommandBase, ISequencingCommandFacade
    {
        public SequencingFacade(ICommandBus commandBus) : base(commandBus)
        {

        }
        public void CreateSequencing(CreateSequencingCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void DeleteSequencing(DeleteSequencingCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void UpdateSequencing(UpdateSequencingCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
