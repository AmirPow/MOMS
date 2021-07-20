using Framework.Core.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.UserContext.ApplicationService.Users
{
    public class SignUpCommand :Command
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
