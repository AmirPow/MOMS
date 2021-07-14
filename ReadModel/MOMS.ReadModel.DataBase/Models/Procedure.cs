using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class Procedure
    {
        public Procedure()
        {
            ProcedureLists = new HashSet<ProcedureList>();
            ReceptionDetails = new HashSet<ReceptionDetail>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual ICollection<ProcedureList> ProcedureLists { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }
    }
}
