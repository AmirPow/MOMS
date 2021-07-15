using Framework.Core.Facade;
using MOMS.ReadModel.Facade.Contracts.Customers.DataContracts;
using MOMS.ReadModel.Facade.Contracts.Sequencing.DataContracts;
using System.Collections.Generic;

namespace MOMS.ReadModel.Facade.Contracts.Sequencing
{
    public interface ISequencingrQueryFacade : IQueryFacade
    {
        List<SequencingDto> GetAll(string keyworad);
    }
}
