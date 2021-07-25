using System;

namespace MOMS.ReadModel.Facade.Contracts.Sequencings.DataContracts
{
    public class SequencingDto
    {
        public Guid CustomerId { get; set; }
        public Guid SequencingId { get; set; }
        public string CustomerName { get; set; }
        public string DoctorName { get; set; }
        public string TherapistName { get; set; }
        public DateTime TurnDateTime { get; set; }
    }
}
