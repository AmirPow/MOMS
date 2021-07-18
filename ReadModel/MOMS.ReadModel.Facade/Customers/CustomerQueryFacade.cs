using MOMS.ReadModel.DataBase.Models;
using MOMS.ReadModel.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System.Collections.Generic;
using System.Linq;

namespace MOMS.ReadModel.Facade.Customers
{
    public class CustomerQueryFacade : ICustomerQueryFacade
    {
        private readonly MOMS_DeveloperContext context;

        public CustomerQueryFacade(MOMS_DeveloperContext context)
        {
            this.context = context;
        }

        public int Enums { get; private set; }

        public List<CustomerDto> GetAll(string keyword)
        {
            var query = context.Customers.AsQueryable();
            if (!string.IsNullOrWhiteSpace(keyword))
                query = query.Where(c => ((c.FirstName + " " + c.LastName).Contains(keyword)) || (c.NationalCode.Contains(keyword)) || (c.MobileNumber.Contains(keyword)));

            return query.Select(c => new CustomerDto()
            {
                CustomerId = c.Id,
                FileNumber = c.FileNumber,
                FirstName = c.FirstName,
                LastName = c.LastName,
                FullName = c.FirstName + " " + c.LastName,
                MobileNumber = c.MobileNumber,
                NationalCode = c.NationalCode,
                RegDateTime = c.RegDateTime,
                Gender = c.Gender,
                MartialStatus = c.MartialStatus,
                FatherName = c.FatherName,
                PhoneNumber = c.PhoneNumber
            }).OrderByDescending(C => C.RegDateTime).ToList();

        }
    }
}
