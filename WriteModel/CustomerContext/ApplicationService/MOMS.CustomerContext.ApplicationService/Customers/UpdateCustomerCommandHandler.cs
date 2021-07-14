using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Domain.Customers;

namespace MOMS.CustomerContext.ApplicationService.Customers
{
    public class UpdateCustomerCommandHandler : ICommandHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(UpdateCustomerCommand command)
        {
            var customer = customerRepository.GetCustomerById(command.CustomerId);
            customer.FirstName = command.FirstName;
            customer.LastName = command.LastName;
            customer.FatherName = command.FatherName;
            customer.NationalCode = command.NationalCode;
            customer.SetMobileNumber(command.MobileNumber);
            customer.PhoneNumber = command.PhoneNumber;
            customer.Gender = command.Gender;
            customer.MartialStatus = command.MartialStatus;
            customerRepository.UpdateCustomer(customer);
        }
    }
}
