using Framework.Core.ApplicationService;
using Microsoft.AspNetCore.Identity;
using MOMS.UserContext.ApplicationService.Users;
using MOMS.UserContext.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Users
{
    public class SignUpCommandHandler : ICommandHandler<SignUpCommand>
    {
        private readonly UserManager<ApplicationUser> userManager;

        public SignUpCommandHandler(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        public void Execute(SignUpCommand command)
        {
            
            var applicationUser = new ApplicationUser();
            applicationUser.UserName = command.UserName;
            applicationUser.PasswordHash = command.Password;

            userManager.CreateAsync(applicationUser);
        }
    }
}
