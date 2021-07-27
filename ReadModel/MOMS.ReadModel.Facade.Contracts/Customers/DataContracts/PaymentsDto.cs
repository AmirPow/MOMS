using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.ReadModel.Facade.Contracts.Customers.DataContracts
{
    public class PaymentsDto
    {
        public string FullName { get; set; }
        public string PaymantNumber { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public int Cash { get; set; }
        public int Pose { get; set; }
        public string TotalPayment { get; set; }
        public  string TotalPrice { get; set; }
    }
}
