using System;

namespace MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts
{
    public class ProcedureListDto
    {
        public Guid ProcedureId { get; set; }
        public string ProcedureName { get; set; }
        public int ProcedurePrice { get; set; }
    }
}
