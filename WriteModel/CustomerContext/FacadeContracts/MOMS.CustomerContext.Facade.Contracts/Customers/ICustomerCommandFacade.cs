using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using System;

namespace MOMS.CustomerContext.Facade.Contracts.Customers
{
    public interface ICustomerCommandFacade
    {
        void CreateCustomer(CreateCustomerCommand command);
        void DeleteCustomer(DeleteCustomerCommand command);
        void UpdateCustomer(UpdateCustomerCommand command);
    }
}
