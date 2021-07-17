using Framework.Core.Facade;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Definitions
{
    public interface IProcedureQueryFacade :IQueryFacade
    {
        List<DoctorListDto> GetDoctors();
        List<TherapistListDto> GetTherapists();
        List<ProcedureListDto> GetProcedures();
    }
}
