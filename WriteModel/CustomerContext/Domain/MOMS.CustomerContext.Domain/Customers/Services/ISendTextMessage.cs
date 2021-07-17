using Framework.Core.Domain;

namespace MOMS.CustomerContext.Domain.Customers.Services
{
    public interface ISendTextMessage :IDomainService
    {
        void Send(Customer customer);
    }
}
