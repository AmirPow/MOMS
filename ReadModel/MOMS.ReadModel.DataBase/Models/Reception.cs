using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class Reception
    {
        public Reception()
        {
            ReceptionDetails = new HashSet<ReceptionDetail>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime ReceptionDateTime { get; set; }
        public int Price { get; set; }
        public int ExteraPrice { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Therapist Therapist { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }
    }
}
