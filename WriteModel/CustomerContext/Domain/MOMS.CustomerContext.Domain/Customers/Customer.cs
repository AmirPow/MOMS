using Framework.Core.Domain;
using Framework.Domain;
using System;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class Customer : EntityBase, IAggregateRoot
    {
        public Customer(string filenumber,
            string firstName,
            string lastName,
            string nationalCode,
            string mobileNumber,
            string phoneNumber,
            int gender,
            int martialStatus)
        {
            FileNumber = filenumber;
            FirstName = firstName;
            LastName = lastName;
            NationalCode = nationalCode;
            MobileNumber = mobileNumber;
            PhoneNumber = phoneNumber;
            Gender = gender;
            MartialStatus = martialStatus;
        }
        protected Customer() { }

        public string FileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
    }
}
