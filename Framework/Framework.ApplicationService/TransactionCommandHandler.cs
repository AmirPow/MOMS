using Framework.Core.ApplicationService;
using Framework.Core.DependencyInjection;
using System;

namespace Framework.ApplicationService
{ 
    public class TransactionCommandHandler<TCommand>:ICommandHandler<TCommand> where TCommand:Command
    {
        private readonly ICommandHandler<TCommand> _commandHandler;
        private readonly IDIContainer _diContainer;

        public TransactionCommandHandler(ICommandHandler<TCommand> commandHandler, IDIContainer diContainer)
        {
            _commandHandler = commandHandler;
            _diContainer = diContainer;
        }
        public void Execute(TCommand command) 
        {
            var unitOfWork = _diContainer.Resolve<IUnitOfWork>();
            try
            {
                _commandHandler.Execute(command);
                unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
