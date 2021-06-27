using MOMS.CustomerContext.ApplicationServiceContracts;
using System;

namespace MOMS.CustomerContext.Facade.Contracts
{
    public interface ICustomerCommandFacade
    {
        void CreateCustomer(CreateCustomerCommand command);
    }
}
