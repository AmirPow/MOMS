using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Domain.Customers;
using MOMS.CustomerContext.Domain.Customers.Services;

namespace MOMS.CustomerContext.ApplicationService.Customers
{
    public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;
        private readonly ISendTextMessage sendTextMessage;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository
            , ISendTextMessage sendTextMessage)
        {
            this.customerRepository = customerRepository;
            this.sendTextMessage = sendTextMessage;
        }
        public void Execute(CreateCustomerCommand command)
        {
            
            var customer = new Customer(
                (customerRepository.GetLastFileNumber() + 1).ToString(),
                command.FirstName,
                command.LastName,
                command.FatherName,
                command.NationalCode,
                command.MobileNumber,
                command.PhoneNumber,
                command.Gender,
                command.MartialStatus);

            customerRepository.CreateCustomer(customer);
            sendTextMessage.Send(customer);
        }
    }
}
