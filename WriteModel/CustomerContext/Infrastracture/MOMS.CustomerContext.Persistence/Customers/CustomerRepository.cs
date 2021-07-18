using Framework.Core.Persistence;
using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using MOMS.CustomerContext.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MOMS.CustomerContext.Persistence.Customers
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbContext dbContext) : base(dbContext)
        {
        }
        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Remove(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            Update(customer);
        }

        public Customer GetCustomerByFileNumber(string fileNumber)
        {
            return _dbContext.Set<Customer>()
                .Include(e => e.Receptions)
                .ThenInclude(e => e.ReceptionDetails)
                .Include(e => e.Receptions)
                .ThenInclude(e => e.Payments)
                .SingleOrDefault(a => a.FileNumber == fileNumber);
        }

        public Customer GetCustomerById(Guid id)
        {
            return _dbContext.Set<Customer>()
                .Include(e => e.Receptions)
                .ThenInclude(e => e.ReceptionDetails)
                .Include(e=>e.Receptions)
                .ThenInclude(e=>e.Payments)
                .SingleOrDefault(a => a.Id == id);
                
        }

        public int GetLastFileNumber()
        {
           var fileNumber = _dbContext.Set<Customer>().Select(a => a.FileNumber).Max();
            if (fileNumber == null)
                fileNumber= "0";              
            return int.Parse(fileNumber);
        }
        public int GetLastPaymentNumber()
        {
            var paymentNumber = _dbContext.Set<Reception>().Select(e => e.PaymentNumber).Max();
            if (paymentNumber == null)
                paymentNumber = "0";
            return int.Parse(paymentNumber);
        }

        protected override IEnumerable<Expression<Func<Customer, object>>> GetAggregateExpression()
        {
            return null;
        }


    }
}
