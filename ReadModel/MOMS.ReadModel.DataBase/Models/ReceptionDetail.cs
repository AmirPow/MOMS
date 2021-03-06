using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class ReceptionDetail
    {
        public Guid Id { get; set; }
        public Guid ReceptionId { get; set; }
        public Guid ProcedureId { get; set; }

        public virtual Procedure Procedure { get; set; }
        public virtual Reception Reception { get; set; }
    }
}
