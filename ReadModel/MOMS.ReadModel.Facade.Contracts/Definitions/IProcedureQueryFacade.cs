using Framework.Core.Facade;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Definitions
{
    public interface IProcedureQueryFacade :IQueryFacade
    {
        List<DoctorListDto> GetDoctors(string searchText);
        List<TherapistListDto> GetTherapists(string searchText);
        List<ProcedureListDto> GetProcedures(string searchText);
    }
}
