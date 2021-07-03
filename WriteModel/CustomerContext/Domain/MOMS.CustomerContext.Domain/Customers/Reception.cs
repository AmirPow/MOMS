using Framework.Domain;
using System;
using System.Collections.Generic;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class Reception : EntityBase
    {
        protected Reception() { }
        public Reception(
            Guid customerId,
            Guid doctorId,
            Guid therapistId,
            int price,
            int extraPrice,
            int discount,
            int totalPrice
            )
        {
            CustomerId = customerId;
            DoctorId = doctorId;
            TherapistId = therapistId;
            ReceptionDateTime = DateTime.Now;
            Price = price;
            ExteraPrice = extraPrice;
            Discount = discount;
            TotalPrice = totalPrice;
        }
        public void AddReceptionDetail(List<Guid> procedureIds)
        {
            foreach (var procedureId in procedureIds)
            {
                var Detail = new ReceptionDetails(Id, procedureId);
                ReceptionDetails.Add(Detail);
            }
        }

        public void AddPayment(Payment payment) 
        {
            Payments.Add(payment);
        }

        
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime ReceptionDateTime { get; set; }
        public int Price { get; set; }
        public int ExteraPrice { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<ReceptionDetails> ReceptionDetails { get; set; } = new HashSet<ReceptionDetails>();
        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();

    }
}
