using MOMS.CustomerContext.ApplicationServiceContracts.Customers;

namespace MOMS.CustomerContext.Facade.Contracts.Customers
{
    public interface IReceptionCommandFacade
    {
        void AddReception(AddReceptionCommand command);
        void DeleteReception(DeleteReceptionCommand command);
        void UpdateReception(UpdateReceptionCommand command);
    }
}
