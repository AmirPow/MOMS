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
    //[Authorize]
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
        [HttpPost]
        [Route("AddPayment")]
        public void AddPayment(AddPaymentCommand command)
        {
            paymentCommandFacade.AddPayment(command);
        }

        [HttpGet]
        [Route("GetAll")]
        public IList<CustomerDto> GetAllCustomers(string keyword)
        {
            return customerQueryFacade.GetAll(keyword);
        }

        [HttpGet]
        [Route("GetCustomerReceptions")]
        public IList<CustomerReceptionsDto> GetCustomerReceptions(string customerFileNumber)
        {
            return customerQueryFacade.GetCustomerReceptions(customerFileNumber);
        }

        [HttpGet]
        [Route("GetCustomerReceptionDetails")]
        public IList<CustomerReceptionDetailsDto> GetCustomerReceptionDetails(Guid receptionId)
        {
            return customerQueryFacade.GetCustomerReceptionDetails(receptionId);
        }

        [HttpGet]
        [Route("GetCustomerPayments")]
        public IList<CustomerPaymentsDto> GetCustomerReceptionDetails(string customerFileNumber)
        {
            return customerQueryFacade.GetCustomerPayments(customerFileNumber);
        }

        [HttpGet]
        [Route("GetReceptionsList")]
        public IList<ReceptionsDto> GetReceptionsList(DateTime startDate,DateTime endDate)
        {
            return customerQueryFacade.GetReceptions(startDate, endDate);
        }

        [HttpGet]
        [Route("GetPaymentsList")]
        public IList<PaymentsDto> GetPaymentsList(DateTime startDate, DateTime endDate)
        {
            return customerQueryFacade.GetPayments(startDate, endDate);
        }
    }
}