 using Framework.Domain;
using System;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class Payment:EntityBase
    {
        protected Payment() { }
        public Payment(
            Guid receptionId,
            int cash,
            int pose)
        {
            ReceptionId = receptionId;
            PaymentDateTime = DateTime.Now;
            Cash = cash;
            Pose = pose;
        }
        public Guid ReceptionId { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public int Cash { get; set; }
        public int Pose { get; set; }
    }
}
