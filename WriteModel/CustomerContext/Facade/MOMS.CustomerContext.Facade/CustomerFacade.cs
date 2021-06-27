using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.CustomerContext.ApplicationServiceContracts;
using MOMS.CustomerContext.Facade.Contracts;
using System;

namespace MOMS.CustomerContext.Facade
{
    public class CustomerFacade : FacadeCommandBase, ICustomerCommandFacade
    {
        public CustomerFacade(ICommandBus commandBus) :base(commandBus)
        {

        }
        public void CreateCustomer(CreateCustomerCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
