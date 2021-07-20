using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.CustomerContext.ApplicationServiceContracts.Customers;
using MOMS.CustomerContext.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerCommandFacade customerCommandFacade;
        private readonly IReceptionCommandFacade receptionCommandFacade;
        private readonly ICustomerQueryFacade customerQueryFacade;
        private readonly IPaymentCommandFacade paymentCommandFacade;

        public CustomerController(
            ICustomerCommandFacade customerCommandFacade,
            IReceptionCommandFacade receptionCommandFacade,
            ICustomerQueryFacade customerQueryFacade,
            IPaymentCommandFacade paymentCommandFacade
            )
        {
            this.customerCommandFacade = customerCommandFacade;
            this.receptionCommandFacade = receptionCommandFacade;
            this.customerQueryFacade = customerQueryFacade;
            this.paymentCommandFacade = paymentCommandFacade;
        }
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
        [HttpPost]
        [Route("AddPayment")]
        public void AddPayment(AddPaymentCommand command)
        {
            paymentCommandFacade.AddPayment(command);
        }

        //[HttpGet]
        //[Route("GetAll")]
        //public IList<CustomerDto> GetAllCustomers()
        //{
        //    return customerQueryFacade.GetAll();
        //}

        [HttpGet]
        [Route("GetCustomerReceptions")]
        public CustomerReceptionList GetCustomerReceptions(string customerFileNumber)
        {
            return customerQueryFacade.GetCustomerReceptions(customerFileNumber);
        }

        [HttpGet]
        [Route("GetCustomerReceptionDetails")]
        public CustomerReceptionDetailList GetCustomerReceptionDetails(Guid receptionId)
        {
            return customerQueryFacade.GetCustomerReceptionDetails(receptionId);
        }

        [HttpGet]
        [Route("GetCustomerPayments")]
        public CustomerPaymentList GetCustomerReceptionDetails(string customerFileNumber)
        {
            return customerQueryFacade.GetCustomerPayments(customerFileNumber);
        }
    }
}