using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.DefinitionContext.ApplicationService.Contracts.Procedures;
using MOMS.DefinitionContext.FacadeContracts.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.DefinitionContext.Facade.Procedures
{
    public class ProcedureFacade : FacadeCommandBase, IProcedureCommandFacade
    {
        public ProcedureFacade(ICommandBus commandBus) : base(commandBus)
        {

        }
        public void Create(CreateProcedureCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
