using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Facade.Contracts.Customers;

namespace MOMS.CustomerContext.Facade.Customers
{
    public class PaymentFacade : FacadeCommandBase, IPaymentCommandFacade
    {
        public PaymentFacade(ICommandBus commandBus) : base(commandBus)
        {

        }
        public void AddPayment(AddPaymentCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void DeletePayment(DeletePaymentCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void UpdatePayment(UpdatePaymentCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
