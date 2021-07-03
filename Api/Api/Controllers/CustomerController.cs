using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Facade.Contracts.Customers;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerCommandFacade customerCommandFacade;
        private readonly IReceptionCommandFacade receptionCommandFacade;

        public CustomerController(
            ICustomerCommandFacade customerCommandFacade,
            IReceptionCommandFacade receptionCommandFacade
            )
        {
            this.customerCommandFacade = customerCommandFacade;
            this.receptionCommandFacade = receptionCommandFacade;
        }
        [HttpPost]
        [Route("CreateCustomer")]
        public void Create(CreateCustomerCommand createCustomerCommand)
        {
            customerCommandFacade.CreateCustomer(createCustomerCommand);
        }
        [HttpPost]
        [Route("DeleteCustomer")]
        public void Delete(DeleteCustomerCommand deleteCustomerCommand)
        {
            customerCommandFacade.DeleteCustomer(deleteCustomerCommand);
        }
        [HttpPost]
        [Route("UpdateCustomer")]
        public void Update(UpdateCustomerCommand UpdateCustomerCommand)
        {
            customerCommandFacade.UpdateCustomer(UpdateCustomerCommand);
        }
        [HttpPost]
        [Route("AddReception")]
        public void AddReception(AddReceptionCommand addReceptionCommand)
        {
            receptionCommandFacade.AddReception(addReceptionCommand);
        }

    }
}