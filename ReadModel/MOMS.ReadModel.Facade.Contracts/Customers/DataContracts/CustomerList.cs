using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.ReadModel.Facade.Contracts.Customers.DataContracts
{
    public class CustomerList
    {
        public IList<CustomerDto> Data { get; set; }
        public int TotalCount { get; set; }
    }
}
