using Framework.Core.Domain;
using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class Customer : EntityBase, IAggregateRoot
    {

        protected Customer() { }
        public Customer(
            string fileNumber,
            string firstName,
            string lastName,
            string fatherName,
            string nationalCode,
            string mobileNumber,
            string phoneNumber,
            int gender,
            int martialStatus)
        {

            FileNumber = fileNumber;
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            NationalCode = nationalCode;
            SetMobileNumber(mobileNumber);
            PhoneNumber = phoneNumber;
            Gender = gender;
            MartialStatus = martialStatus;
            RegDateTime = DateTime.Now;
        }

        public string FileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
        public DateTime RegDateTime { get; set; }
        public ICollection<Reception> Receptions { get; set; } = new HashSet<Reception>();

        public void AddReception(Reception reception)
        {
            Receptions.Add(reception);
        }

        public void SetMobileNumber(string mobileNumber)
        {
            if (mobileNumber.Length != 11)
                throw new Exception("طول شماره تلفن همراه صحیح نیست");
            if (!mobileNumber.Any(char.IsDigit))
                throw new Exception("شماره تلفن همراه باید عددی باشد");
            MobileNumber = mobileNumber;
        }
    }
}
