﻿using Framework.Core.ApplicationService;
using MOMS.CustomerContext.ApplicationServiceContracts;
using MOMS.CustomerContext.Domain.Customers;
using MOMS.CustomerContext.Domain.Customers.Services;
using MOMS.CustomerContext.DomainService.Customers;
using System;

namespace MOMS.CustomerContext.ApplicationService
{
    public class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;
        private readonly ISendTextMessage sendTextMessage;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository
            ,ISendTextMessage sendTextMessage)
        {
            this.customerRepository = customerRepository;
            this.sendTextMessage = sendTextMessage;
        }
        public void Execute(CreateCustomerCommand command)
        {
            
            var customer = new Customer(
                (customerRepository.GetLastFileNumber()+1).ToString(),
                command.FirstName,
                command.LastName,
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
