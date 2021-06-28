using Framework.Core.ApplicationService;
using System;

namespace MOMS.CustomerContext.ApplicationServiceContracts
{
    public class CreateCustomerCommand :Command
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
    }
}
