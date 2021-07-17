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

        public List<CustomerDto> GetAll()
        {
            return (from customer in context.Customers
                        //join reception in context.Receptions on customer.Id equals reception.CustomerId
                        //join payment in context.Payments on reception.Id equals payment.ReceptionId
                    select new CustomerDto()
                    {
                        FileNumber = customer.FileNumber,
                        FullName = customer.FirstName + " " + customer.LastName,
                        FatherName = customer.FatherName,
                        MobileNumber = customer.MobileNumber,
                        PhoneNumber = customer.PhoneNumber,
                        Gender = customer.Gender,
                        MartialStatus = customer.MartialStatus,
                        RegDateTime = customer.RegDateTime,
                        NationalCode = customer.NationalCode,

                    })
                    .ToList();
        }
    }
}
