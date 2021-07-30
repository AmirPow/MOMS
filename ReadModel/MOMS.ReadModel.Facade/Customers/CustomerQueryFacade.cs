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
        public IList<CustomerDto> GetAll(string keyword)
        {
            var query = context.Customers.AsQueryable();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(r => (r.FirstName.Contains(keyword)) || (r.LastName.Contains(keyword)) || (r.FileNumber == keyword));
            return query.Select(r => new CustomerDto()
            {
                FileNumber = r.FileNumber,
                CustomerId = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                FullName = r.FirstName + " " + r.LastName,
                FatherName = r.FatherName,
                MobileNumber = r.MobileNumber,
                PhoneNumber = r.PhoneNumber,
                Gender = r.Gender,
                MartialStatus = r.MartialStatus,
                RegDateTime = r.RegDateTime,
                NationalCode = r.NationalCode,
                ReceptionCouunt = r.Receptions.Count()
            }).ToList();
          

        }
        public IList<CustomerReceptionsDto> GetCustomerReceptions(string customerFileNumber)
        {

            return (from customer in context.Customers
                    join reception in context.Receptions on customer.Id equals reception.CustomerId
                    join doctor in context.Doctors on reception.DoctorId equals doctor.Id
                    join therapist in context.Therapists on reception.TherapistId equals therapist.Id
                    where customer.FileNumber == customerFileNumber
                    select new CustomerReceptionsDto
                    {
                        ReceptionId = reception.Id,
                        PaymentNumber = reception.PaymentNumber,
                        CustomerFullName = customer.FirstName + " " + customer.LastName,
                        ReceptionDateTime = reception.ReceptionDateTime,
                        DoctorName = doctor.FirstName + " " + doctor.LastName,
                        TherapistIdName = therapist.FirstName + " " + therapist.LastName,
                        Price = reception.Price,
                        ExteraPrice = reception.ExteraPrice,
                        Discount = reception.Discount,
                        TotalPrice = reception.TotalPrice
                    }).ToList();
            

        }
        public IList<CustomerReceptionDetailsDto> GetCustomerReceptionDetails(Guid receptionId)
        {
            return (from reception in context.Receptions
                    join receptionDetail in context.ReceptionDetails on reception.Id equals receptionDetail.ReceptionId
                    join procedure in context.Procedures on receptionDetail.ProcedureId equals procedure.Id
                    where reception.Id == receptionId
                    select new CustomerReceptionDetailsDto
                    {
                        Name = procedure.Name
                    }
                    ).ToList();
           
        }
        public IList<CustomerPaymentsDto> GetCustomerPayments(string customerFileNumber)
        {
            return (from customer in context.Customers
                    join reception in context.Receptions on customer.Id equals reception.CustomerId
                    join payment in context.Payments on reception.Id equals payment.ReceptionId
                    where customer.FileNumber == customerFileNumber
                    select new CustomerPaymentsDto
                    {
                        PaymentNumber = reception.PaymentNumber,
                        PaymentDateTime = payment.PaymentDateTime,
                        Cash = payment.Cash,
                        Pose = payment.Pose
                    }).ToList();
        }
        public IList<ReceptionsDto>  GetReceptions(DateTime startDate , DateTime endDate)
        {
            return (from customer in context.Customers
                              join reception in context.Receptions on customer.Id equals reception.CustomerId
                              join doctor in context.Doctors on reception.DoctorId equals doctor.Id
                              join therapist in context.Therapists on reception.TherapistId equals therapist.Id
                              where reception.ReceptionDateTime.Date >= startDate.Date  && reception.ReceptionDateTime.Date <= endDate.Date
                              select new ReceptionsDto
                              {
                                  ReceptionId = reception.Id,
                                  PaymentNumber = reception.PaymentNumber,
                                  CustomerFullName = customer.FirstName + " " + customer.LastName,
                                  ReceptionDateTime = reception.ReceptionDateTime,
                                  DoctorName = doctor.FirstName + " " + doctor.LastName,
                                  TherapistIdName = therapist.FirstName + " " + therapist.LastName,
                                  Price = reception.Price,
                                  ExteraPrice = reception.ExteraPrice,
                                  Discount = reception.Discount,
                                  TotalPrice = reception.TotalPrice
                              }).ToList();
        }
        public IList<PaymentsDto> GetPayments(DateTime startDate, DateTime endDate)
        {
            return (from payment in context.Payments
                            join reception in context.Receptions on payment.ReceptionId equals reception.Id
                            join customer in context.Customers on reception.CustomerId equals customer.Id
                            where reception.ReceptionDateTime.Date >= startDate.Date && reception.ReceptionDateTime.Date <= endDate.Date
                            select new PaymentsDto
                            {
                                FullName = customer.FirstName + " " + customer.LastName, 
                                PaymantNumber = reception.PaymentNumber,
                                PaymentDateTime = payment.PaymentDateTime,
                                Pose = payment.Pose,
                                Cash = payment.Cash,
                                TotalPayment = (payment.Cash + payment.Pose).ToString(),
                                TotalPrice = reception.TotalPrice.ToString()
                            }
                            ).ToList();           
        }
    }
}
