using Framework.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Customers.Services
{
    public interface ISendTextMessage :IDomainService
    {
        void Send(Customer customer);
    }
}
