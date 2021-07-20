using MOMS.UserContext.ApplicationService.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.UserContext.Facade.Contracts.Users
{
    public interface IUserCommandFacade
    {
        void SignIn(SignInCommand command);
        void SignUp(SignUpCommand command);
    }
}
