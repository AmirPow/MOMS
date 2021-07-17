using Framework.Core.ApplicationService;
using MOMS.DefinitionContext.ApplicationService.Contracts.Procedures;
using MOMS.DefinitionContext.Domain.Procedures;

namespace MOMS.DefinitionContext.ApplicationService.Procedures
{
    public class CreateProcedureCommandHandler : ICommandHandler<CreateProcedureCommand>
    {
        private readonly IProcedureRepository procedureRepository;

        public CreateProcedureCommandHandler(IProcedureRepository procedureRepository)
        {
            this.procedureRepository = procedureRepository;
        }
        public void Execute(CreateProcedureCommand command)
        {
            var procedure = new Procedure(command.Name, command.Price);
            procedureRepository.CreateProcedure(procedure);
        }
    }
}
