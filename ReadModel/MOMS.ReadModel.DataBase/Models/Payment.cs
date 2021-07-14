using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class Payment
    {
        public Guid Id { get; set; }
        public Guid ReceptionId { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public int Cash { get; set; }
        public int Pose { get; set; }

        public virtual Reception Reception { get; set; }
    }
}
