using Framework.Core.ApplicationService;
using System;

namespace MOMS.CustomerContext.ApplicationServiceContracts.Customers
{
    public class AddPaymentCommand : Command
    {
        public string CustomerFileNumber { get; set; }
        public Guid ReceptionId { get; set; }
        public int Cash { get; set; }
        public int Pose { get; set; }
    }
}
