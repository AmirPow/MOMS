using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.ReadModel.Facade.Contracts.Customers.DataContracts
{
    public class CustomerReceptionsDto
    {
        public Guid ReceptionId { get; set; }
        public string PaymentNumber { get; set; }
        public string CustomerFullName { get; set; }
        public string DoctorName  { get; set; }
        public string TherapistIdName { get; set; }
        public DateTime ReceptionDateTime { get; set; }
        public int Price { get; set; }
        public int ExteraPrice { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }       
    }
}
