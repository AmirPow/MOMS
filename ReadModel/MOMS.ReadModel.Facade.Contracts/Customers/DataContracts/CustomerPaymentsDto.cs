using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.ReadModel.Facade.Contracts.Customers.DataContracts
{
    public class CustomerPaymentsDto
    {
        public string PaymentNumber { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public int Cash { get; set; }
        public int Pose { get; set; }
    }
}
