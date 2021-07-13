using MOMS.ReadModel.DataBase;
using MOMS.ReadModel.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.ReadModel.Facade.Customers
{
    public class CustomerQueryFacade : ICustomerQueryFacade
    {
        private readonly MOMS_DeveloperContext context;

        public CustomerQueryFacade(MOMS_DeveloperContext context)
        {
            this.context = context;
        }
        public List<CustomerDto> GetAll()
        {
            return (from customer in context.Customers
                    select new CustomerDto
                    {
                        FileNumber = customer.FileNumber,
                        FirstName = customer.FirstName,
                        MobileNumber = customer.MobileNumber
                    }).ToList();             
        }
    }
}
