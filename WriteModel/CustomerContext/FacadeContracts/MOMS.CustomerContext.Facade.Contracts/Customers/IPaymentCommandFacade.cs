using MOMS.CustomerContext.ApplicationServiceContracts.Customers;

namespace MOMS.CustomerContext.Facade.Contracts.Customers
{
    public interface IPaymentCommandFacade
    {
        void AddPayment(AddPaymentCommand command);
        void DeletePayment(DeletePaymentCommand command);
        void UpdatePayment(UpdatePaymentCommand command);
    }
}
