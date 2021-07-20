using Framework.Core.ApplicationService;
using Framework.Facade;
using MOMS.UserContext.ApplicationService.Users;
using MOMS.UserContext.Facade.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.UserContext.Facade.Users
{
    public class UserFacade : FacadeCommandBase, IUserCommandFacade
    {
        public UserFacade(ICommandBus commandBus) : base(commandBus)
        {

        }

        public void SignIn(SignInCommand command)
        {
            _commandBus.Dispatch(command);
        }

        public void SignUp(SignUpCommand command)
        {
            _commandBus.Dispatch(command);
        }
    }
}
