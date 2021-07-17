using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Domain.Customers;

namespace MOMS.CustomerContext.ApplicationService.Customers
{
    public class AddReceptionCommandHandler : ICommandHandler<AddReceptionCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public AddReceptionCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(AddReceptionCommand command)
        {
            var customer = customerRepository.GetCustomerByFileNumber(command.CustomerFileNumber);

            var newReception = new Reception(
                customer.Id,
                command.DoctorId,
                command.TherapistId,
                command.Price,
                command.ExteraPrice,
                command.Discount,
                command.TotalPrice);
            newReception.AddReceptionDetail(command.ProcedureList);
            
            customer.Receptions.Add(newReception);
        }
    }
}
