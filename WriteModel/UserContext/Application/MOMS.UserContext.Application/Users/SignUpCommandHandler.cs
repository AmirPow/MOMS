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
    public class SignUpCommandHandler : ICommandHandler<SignUpCommand>
    {


        public SignUpCommandHandler()
        {

        }
        public void Execute(SignUpCommand command)
        {



        }
    }
}
