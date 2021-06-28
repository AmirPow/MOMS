using Framework.Core.Persistence;
using Framework.Persistence;
using MOMS.CustomerContext.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Persistence.Customers
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbContext dbContext) :base (dbContext)
        {

        }
        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }

        public int GetLastFileNumber()
        {
            return int.Parse(_dbContext.Set<Customer>().Select(a => a.FileNumber).Max());
        }

        protected override IEnumerable<Expression<Func<Customer, object>>> GetAggregateExpression()
        {
            return null;
        }
    }
}
