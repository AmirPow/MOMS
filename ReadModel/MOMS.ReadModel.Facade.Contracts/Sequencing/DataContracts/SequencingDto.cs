using System;

namespace MOMS.ReadModel.Facade.Contracts.Sequencing.DataContracts
{
    public class SequencingDto
    {
        public Guid SequencingId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime TurnDateTime { get; set; }
    }
}
