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
        CustomerReceptionList GetCustomerReceptions(string customerFileNumber);
        CustomerReceptionDetailList GetCustomerReceptionDetails (Guid receptionId);
        CustomerPaymentList GetCustomerPayments(string customerFileNumber);
        IList<ReceptionsDto> GetReceptions(DateTime startDate , DateTime endDate);
        PaymentsList GetPayments(DateTime startDate, DateTime endDate);
    }
}
