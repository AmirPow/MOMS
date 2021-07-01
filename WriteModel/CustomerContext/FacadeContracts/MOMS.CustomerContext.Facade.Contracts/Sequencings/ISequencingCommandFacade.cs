using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Facade.Contracts.Sequencings
{
    public interface ISequencingCommandFacade
    {
        void CreateSequencing(CreateSequencingCommand command);
        void DeleteSequencing(DeleteSequencingCommand command);
        void UpdateSequencing(UpdateSequencingCommand command);
    }
}
