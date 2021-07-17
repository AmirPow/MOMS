using Framework.Core.ApplicationService;

namespace MOMS.DefinitionContext.ApplicationService.Contracts.Procedures
{
    public class CreateProcedureCommand : Command
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
