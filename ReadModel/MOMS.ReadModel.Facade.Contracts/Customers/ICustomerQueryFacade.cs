using Framework.Core.Facade;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Customers
{
    public interface ICustomerQueryFacade :IQueryFacade
    {
        IList<CustomerDto> GetAll(string keyword);
        IList<CustomerReceptionsDto> GetCustomerReceptions(string customerFileNumber);
        IList<CustomerReceptionDetailsDto> GetCustomerReceptionDetails(Guid receptionId);
        IList<CustomerPaymentsDto> GetCustomerPayments(string customerFileNumber);
        IList<ReceptionsDto> GetReceptions(DateTime startDate, DateTime endDate);
        IList<PaymentsDto> GetPayments(DateTime startDate, DateTime endDate);
    }
}
