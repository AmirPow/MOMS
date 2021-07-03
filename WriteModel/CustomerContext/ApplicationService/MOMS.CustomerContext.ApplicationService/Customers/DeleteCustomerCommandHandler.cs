using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Domain.Customers;

namespace MOMS.CustomerContext.ApplicationService.Customers
{
    public class DeleteCustomerCommandHandler : ICommandHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(DeleteCustomerCommand command)
        {
            var customer = customerRepository.GetCustomerByFileNumber(command.FileNumber);
            customerRepository.DeleteCustomer(customer);
        }
    }
}
