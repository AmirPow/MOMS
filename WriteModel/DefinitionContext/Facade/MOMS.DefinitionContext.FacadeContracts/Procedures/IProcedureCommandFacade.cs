using MOMS.DefinitionContext.ApplicationService.Contracts.Procedures;

namespace MOMS.DefinitionContext.FacadeContracts.Procedures
{
    public interface IProcedureCommandFacade
    {
        void Create(CreateProcedureCommand command);
    }
}
