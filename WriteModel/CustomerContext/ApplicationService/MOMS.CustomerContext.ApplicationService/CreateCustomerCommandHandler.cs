using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts;
using MOMS.CustomerContext.Domain.Customers;
using System;

namespace MOMS.CustomerContext.ApplicationService
{
    public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(CreateCustomerCommand command)
        {
            var customer = new Customer(command.FileNumber,
                command.FirstName,
                command.LastName,
                command.NationalCode,
                command.MobileNumber,
                command.PhoneNumber,
                command.Gender,
                command.MartialStatus);
            customerRepository.CreateCustomer(customer);
        }
    }
}
