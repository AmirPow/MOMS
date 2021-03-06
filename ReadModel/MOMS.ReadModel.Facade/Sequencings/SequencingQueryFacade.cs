using MOMS.ReadModel.DataBase.Models;
using MOMS.ReadModel.Facade.Contracts.Sequencings;
using MOMS.ReadModel.Facade.Contracts.Sequencings.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MOMS.ReadModel.Facade.Sequencings
{
    public class SequencingQueryFacade :ISequencingQueryFacade
    {
        private readonly MOMS_DeveloperContext context;

        public SequencingQueryFacade(MOMS_DeveloperContext context)
        {
            this.context = context;
        }

        public List<SequencingDto> GetAll(DateTime startDate , DateTime endDate)
        {
            return (from sequencing in context.Sequencings
                     join customer in context.Customers on sequencing.CustomerId equals customer.Id
                     join doctor in context.Doctors on sequencing.DoctorId equals doctor.Id
                     join therapist in context.Therapists on sequencing.TherapistId equals therapist.Id
                    where sequencing.TurnDateTime.Date >= startDate.Date && sequencing.TurnDateTime.Date <= endDate.Date
                    select new SequencingDto
                     {
                         CustomerId = customer.Id,
                         SequencingId = sequencing.Id,
                         CustomerName = customer.FirstName + " " + customer.LastName,
                         DoctorName = doctor.FirstName + " " + doctor.LastName,
                         TherapistName = therapist.FirstName + " " + therapist.LastName,
                         TurnDateTime = sequencing.TurnDateTime
                     }).ToList();            
        }

        public IList<CustomerSequencingDto> GetCustomerSequencing(string customerFileNumber)
        {
            return (from sequencing in context.Sequencings
                    join customer in context.Customers on sequencing.CustomerId equals customer.Id
                    join doctor in context.Doctors on sequencing.DoctorId equals doctor.Id
                    join therapist in context.Therapists on sequencing.TherapistId equals therapist.Id
                    where customer.FileNumber == customerFileNumber
                    select new CustomerSequencingDto
                    {
                        CustomerId = customer.Id,
                        SequencingId = sequencing.Id,
                        CustomerName = customer.FirstName + " " + customer.LastName,
                        DoctorName = doctor.FirstName + " " + doctor.LastName,
                        TherapistName = therapist.FirstName + " " + therapist.LastName,
                        TurnDateTime = sequencing.TurnDateTime
                    }).OrderByDescending(c=>c.TurnDateTime)
                    .ToList();
        }
    }
}
