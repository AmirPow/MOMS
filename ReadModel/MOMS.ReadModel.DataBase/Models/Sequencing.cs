using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class Sequencing
    {
        public Sequencing()
        {
            ProcedureLists = new HashSet<ProcedureList>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime SubmitDateTime { get; set; }
        public DateTime TurnDateTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Therapist Therapist { get; set; }
        public virtual ICollection<ProcedureList> ProcedureLists { get; set; }
    }
}
