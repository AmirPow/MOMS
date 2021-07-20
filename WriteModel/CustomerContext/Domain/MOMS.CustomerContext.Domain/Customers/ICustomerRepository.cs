using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Customers
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        int GetLastFileNumber();
        int GetLastPaymentNumber();
        Customer GetCustomerByFileNumber(string fileNumber);
        Customer GetCustomerById(Guid id);
        
    }
}
