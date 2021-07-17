using System;

namespace MOMS.DefinitionContext.Domain.Procedures
{
    public interface IProcedureRepository 
    {
        void CreateProcedure(Procedure procedure);
        void DeleteProcedure(Procedure procedure);
        void UpdateProcedure(Procedure procedure);
        Procedure GetByProcedureById(Guid procedureId);
    }
}
