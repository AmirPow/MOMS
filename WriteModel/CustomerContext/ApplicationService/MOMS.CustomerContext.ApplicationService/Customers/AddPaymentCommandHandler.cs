using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Domain.Customers;
using System.Linq;
namespace MOMS.CustomerContext.ApplicationService.Customers
{
    public class AddPaymentCommandHandler : ICommandHandler<AddPaymentCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public AddPaymentCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(AddPaymentCommand command)
        {
            var customer = customerRepository.GetCustomerByFileNumber(command.CustomerFileNumber);
            var payment = new Payment(command.ReceptionId, command.Cash, command.Pose);
            var reception = customer.Receptions.Single(e => e.Id == command.ReceptionId);
            reception.AddPayment(payment);
        }
    }
}
