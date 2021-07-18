using MOMS.ReadModel.DataBase.Models;
using MOMS.ReadModel.Facade.Contracts.Definitions;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System.Collections.Generic;
using System.Linq;

namespace MOMS.ReadModel.Facade.Definitions
{
    public class DefinitionQueryFacade : IProcedureQueryFacade
    {
        private readonly MOMS_DeveloperContext context;

        public DefinitionQueryFacade(MOMS_DeveloperContext context)
        {
            this.context = context;
        }
        public List<DoctorListDto> GetDoctors()
        {
            return (from doctor in context.Doctors
                    select new DoctorListDto
                    {
                        DoctorId = doctor.Id,
                        FullName = doctor.FirstName + " " + doctor.LastName
                    }
                    ).ToList();
        }

        public List<TherapistListDto> GetTherapists()
        {
            return (from therapist in context.Therapists
                    select new TherapistListDto
                    {
                        TherapistId = therapist.Id,
                        FullName = therapist.FirstName + therapist.LastName
                    }
                    ).ToList();
        }

        public List<ProcedureListDto> GetProcedures()
        {
            return (from procedure in context.Procedures
                    select new ProcedureListDto
                    {
                        ProcedureId = procedure.Id,
                        ProcedureName = procedure.Name,
                        ProcedurePrice = procedure.Price
                    }
                    ).ToList();
        }
    }
}
