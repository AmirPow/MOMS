using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Sequencings
{
    public interface ISequencingRepository
    {
        void CreateSequencing(Sequencing sequencing);
        void DeleteSequencing(Sequencing sequencing);
        void UpdateSequencing(Sequencing sequencing);
        Sequencing GetBySequencingId(Guid sequencingId);
    }
}
