﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Customers
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        //Customer GetCustomerByFileNumber(string fileNumber);
        //Customer GetCustomerById(Guid id);
        //List<Customer> GetCustomerList();
        //bool IsExist(string fileNumber);
    }
}
