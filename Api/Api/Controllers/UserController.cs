using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.UserContext.ApplicationService.Users;
using MOMS.UserContext.Facade.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserCommandFacade userCommandFacade;

        public UserController(IUserCommandFacade userCommandFacade)
        {
            this.userCommandFacade = userCommandFacade;
        }

        [HttpPost]
        [Route("SignUp")]
        public void SignUp(SignUpCommand command)
        {
            userCommandFacade.SignUp(command);
        }
    }
}
