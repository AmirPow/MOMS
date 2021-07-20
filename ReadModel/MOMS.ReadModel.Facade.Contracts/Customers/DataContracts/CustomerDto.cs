using System;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Customers.DataContracts
{
    public class CustomerDto
    {
        public string FileNumber { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
        public DateTime RegDateTime { get; set; }
        public int ReceptionCouunt { get; set; }     
    }
}
