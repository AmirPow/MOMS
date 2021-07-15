using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using MOMS.ReadModel.Facade.Contracts.Sequencing;
using MOMS.ReadModel.Facade.Contracts.Sequencing.DataContracts;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerCommandFacade customerCommandFacade;
        private readonly IReceptionCommandFacade receptionCommandFacade;
        private readonly ISequencingrQueryFacade customerQueryFacade;

        public CustomerController(
            ICustomerCommandFacade customerCommandFacade,
            IReceptionCommandFacade receptionCommandFacade,
            ISequencingrQueryFacade customerQueryFacade
            )
        {
            this.customerCommandFacade = customerCommandFacade;
            this.receptionCommandFacade = receptionCommandFacade;
            this.customerQueryFacade = customerQueryFacade;
        }
        [HttpPost]
        [Route("CreateCustomer")]
        public void Create(CreateCustomerCommand createCustomerCommand)
        {
            customerCommandFacade.CreateCustomer(createCustomerCommand);
        }
        [HttpDelete]
        [Route("DeleteCustomer")]
        public void Delete(DeleteCustomerCommand deleteCustomerCommand)
        {
            customerCommandFacade.DeleteCustomer(deleteCustomerCommand);
        }
        [HttpPut]
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

        [HttpGet]
        [Route("GetAll")]
        public IList<SequencingDto> GetAllCustomers(string keyword)
        {
            return customerQueryFacade.GetAll(keyword);
        }
    }
}