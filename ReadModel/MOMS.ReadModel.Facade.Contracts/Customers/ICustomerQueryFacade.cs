using Framework.Core.Facade;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Customers
{
    public interface ICustomerQueryFacade :IQueryFacade
    {
        List<CustomerDto> GetAll();
    }
}
