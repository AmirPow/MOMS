using MOMS.ReadModel.Facade.Contracts.Sequencings.DataContracts;
using System;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Sequencings
{
    public interface ISequencingQueryFacade
    {
        List<SequencingDto> GetAll(string keyworad , DateTime startDate,DateTime endDate);
    }
}
