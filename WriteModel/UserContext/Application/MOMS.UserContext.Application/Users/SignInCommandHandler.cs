using Framework.Core.ApplicationService;
using Microsoft.AspNetCore.Identity;
using MOMS.UserContext.ApplicationService.Users;
using MOMS.UserContext.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.UserContext.Application.Users
{
    public class SignInCommandHandler : ICommandHandler<SignInCommand>
    {
        

        public SignInCommandHandler()
        {
            
        }
        public void Execute(SignInCommand command)
        {
            
           

            
        }
    }
}
