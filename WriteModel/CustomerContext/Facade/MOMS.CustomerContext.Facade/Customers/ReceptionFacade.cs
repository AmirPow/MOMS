using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Facade.Contracts.Customers;
using System;

namespace MOMS.CustomerContext.Facade.Customers
{
    public class ReceptionFacade : FacadeCommandBase, IReceptionCommandFacade
    {
        public ReceptionFacade(ICommandBus commandBus) : base(commandBus)
        {
           
        }
        public void AddReception(AddReceptionCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void DeleteReception(DeleteReceptionCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void UpdateReception(UpdateReceptionCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
