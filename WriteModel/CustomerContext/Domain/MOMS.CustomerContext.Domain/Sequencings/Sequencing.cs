using Framework.Core.Domain;
using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Sequencings
{
    public class Sequencing : EntityBase , IAggregateRoot
    {
        protected Sequencing()
        {

        }
        public Sequencing(Guid customerId,
            Guid doctorId,
            Guid therapistId,
            DateTime turnDateTime
            )
        {
            CustomerId = customerId;
            DoctorId = doctorId;
            TherapistId = therapistId;
            SubmitDateTime = DateTime.Now;
            SetTurnDateTime(turnDateTime);
        }

        private void SetTurnDateTime(DateTime turnDateTime)
        {
            if (turnDateTime < DateTime.Now)
                throw new Exception("زمان غیر مجاز می باشد");
            TurnDateTime = turnDateTime;
        }

        public void AddProcedureList(List<Guid> procedureList)
        {
            foreach (var procedureId in procedureList)
            {
                var procedure = new ProcedureList(Id, procedureId);
                ProcedureLists.Add(procedure);
            }
        }

        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public DateTime SubmitDateTime { get; set; }
        public DateTime TurnDateTime { get; set; }
        public ICollection<ProcedureList> ProcedureLists { get; set; } = new HashSet<ProcedureList>();
    }
}
