using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Facade.Contracts.Customers
{
    public interface IReceptionCommandFacade
    {
        void AddReception(AddReceptionCommand command);
        void DeleteReception(DeleteReceptionCommand command);
        void UpdateReception(UpdateReceptionCommand command);
    }
}
