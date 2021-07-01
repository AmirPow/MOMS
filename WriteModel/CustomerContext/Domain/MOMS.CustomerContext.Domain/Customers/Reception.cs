using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class Reception : EntityBase
    {
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime receptionDateTime { get; set; }
        public int Price { get; set; }
        public int ExteraPrice { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<ReceptionDetails> ReceptionDetails { get; set; } = new HashSet<ReceptionDetails>();
        public ICollection<Payment> Peyments { get; set; } = new HashSet<Payment>();

    }
}
