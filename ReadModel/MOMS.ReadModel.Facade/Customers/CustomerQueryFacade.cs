using MOMS.ReadModel.DataBase.Models;
using MOMS.ReadModel.Facade.Contracts.Customers;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MOMS.ReadModel.Facade.Customers
{
    public class CustomerQueryFacade : ICustomerQueryFacade
    {
        private readonly MOMS_DeveloperContext context;

        public CustomerQueryFacade(MOMS_DeveloperContext context)
        {
            this.context = context;
        }

        public int Enums { get; private set; }

        public CustomerList GetAll()
        {
            var customers = (from customer in context.Customers
                             select new CustomerDto()
                             {
                                 FileNumber = customer.FileNumber,
                                 FullName = customer.FirstName + " " + customer.LastName,
                                 FatherName = customer.FatherName,
                                 MobileNumber = customer.MobileNumber,
                                 PhoneNumber = customer.PhoneNumber,
                                 Gender = customer.Gender,
                                 MartialStatus = customer.MartialStatus,
                                 RegDateTime = customer.RegDateTime,
                                 NationalCode = customer.NationalCode,
                                 ReceptionCouunt = customer.Receptions.Count(),
                             });



            return new CustomerList { Data = customers.ToList(), TotalCount = customers.Count() };

        }

        public CustomerReceptionList GetCustomerReceptions(string customerFileNumber)
        {

            var cutomerReceptions = (from customer in context.Customers
                                     join reception in context.Receptions on customer.Id equals reception.CustomerId
                                     join doctor in context.Doctors on reception.DoctorId equals doctor.Id
                                     join therapist in context.Therapists on reception.TherapistId equals therapist.Id
                                     where customer.FileNumber == customerFileNumber
                                     select new CustomerReceptionsDto
                                     {
                                         CustomerFullName = customer.FirstName + " " + customer.LastName,
                                         ReceptionDateTime = reception.ReceptionDateTime,
                                         DoctorName = doctor.FirstName + " " + doctor.LastName,
                                         TherapistIdName = therapist.FirstName + " " + therapist.LastName,
                                         Price = reception.Price,
                                         ExteraPrice = reception.ExteraPrice,
                                         Discount = reception.Discount,
                                         TotalPrice = reception.TotalPrice,
                                     });
            return new CustomerReceptionList { Data = cutomerReceptions.ToList(), TotalCount = cutomerReceptions.Count() };

        }
        public CustomerReceptionDetailList GetCustomerReceptionDetails(Guid receptionId)
        {
            var customerReceptionDetails = (from reception in context.Receptions
                                            join receptionDetail in context.ReceptionDetails on reception.Id equals receptionDetail.ReceptionId
                                            join procedure in context.Procedures on receptionDetail.ProcedureId equals procedure.Id
                                            where reception.Id == receptionId
                                            select new CustomerReceptionDetailsDto
                                            {
                                                Name = procedure.Name
                                            }
                    );
            return new CustomerReceptionDetailList { Data = customerReceptionDetails.ToList(), TotalCount = customerReceptionDetails.Count() };
        }

        public CustomerPaymentList GetCustomerPayments(string customerFileNumber)
        {
            var customerPayments = (from customer in context.Customers
                                    join reception in context.Receptions on customer.Id equals reception.CustomerId
                                    join payment in context.Payments on reception.Id equals payment.ReceptionId
                                    where customer.FileNumber == customerFileNumber
                                    select new CustomerPaymentsDto
                                    {
                                        PaymentNumber = reception.PaymentNumber,
                                        PaymentDateTime = payment.PaymentDateTime,
                                        Cash = payment.Cash,
                                        Pose = payment.Pose
                                    }
                                    );
            var totalPayment = customerPayments.Select(e => e.Pose).Sum() + customerPayments.Select(e => e.Cash).Sum();
            return new CustomerPaymentList { Data = customerPayments.ToList(), TotalCount = customerPayments.Count(), TotalPayment = totalPayment };
        }
    }
}
