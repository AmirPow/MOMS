using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class ProcedureList
    {
        public Guid Id { get; set; }
        public Guid SequencingId { get; set; }
        public Guid ProcedureId { get; set; }

        public virtual Procedure Procedure { get; set; }
        public virtual Sequencing Sequencing { get; set; }
    }
}
