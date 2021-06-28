using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Facade.Contracts.Customers;

namespace MOMS.CustomerContext.Facade.Customers
{
    public class CustomerFacade : FacadeCommandBase, ICustomerCommandFacade
    {
        public CustomerFacade(ICommandBus commandBus) : base(commandBus)
        {

        }
        public void CreateCustomer(CreateCustomerCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void DeleteCustomer(DeleteCustomerCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void UpdateCustomer(UpdateCustomerCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
