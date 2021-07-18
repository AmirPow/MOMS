using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.ReadModel.Facade.Contracts.Customers.DataContracts
{
    public class CustomerPaymentList
    {
        public IList<CustomerPaymentsDto> Data { get; set; }
        public int TotalCount { get; set; }
        public int TotalPayment { get; set; }
    }
}
