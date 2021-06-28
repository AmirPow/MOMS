using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.CustomerContext.ApplicationServiceContracts;
using MOMS.CustomerContext.Facade.Contracts;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerCommandFacade customerCommandFacade;

        public CustomerController(ICustomerCommandFacade customerCommandFacade)
        {
            this.customerCommandFacade = customerCommandFacade;
        }
        [HttpPost]
        public void Create(CreateCustomerCommand createCustomerCommand)
        {
            customerCommandFacade.CreateCustomer(createCustomerCommand);
        }
    }
}