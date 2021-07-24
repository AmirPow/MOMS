using Framework.Core.ApplicationService;
using System;

namespace MOMS.CustomerContext.ApplicationServiceContracts.Customers
{
    public class DeleteCustomerCommand : Command
    {
        public Guid CustomerId { get; set; }
    }
}
