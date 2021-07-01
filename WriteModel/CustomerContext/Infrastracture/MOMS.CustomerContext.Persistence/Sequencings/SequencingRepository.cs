using Framework.Core.Persistence;
using Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using MOMS.CustomerContext.Domain.Sequencings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MOMS.CustomerContext.Persistence.Sequencings
{
    public class SequencingRepository : RepositoryBase<Sequencing>, ISequencingRepository
    {
        public SequencingRepository(IDbContext dbContext) : base(dbContext)
        {

        }
        public void CreateSequencing(Sequencing sequencing)
        {
            Create(sequencing);
        }

        public void DeleteSequencing(Sequencing sequencing)
        {
            Remove(sequencing);
        }

        public void UpdateSequencing(Sequencing sequencing)
        {
            Update(sequencing);
        }
        public Sequencing GetBySequencingId(Guid sequencingId)
        {
            return _dbContext.Set<Sequencing>().Include(e=>e.ProcedureLists)
                .SingleOrDefault(a=>a.Id==sequencingId);
        }

        protected override IEnumerable<Expression<Func<Sequencing, object>>> GetAggregateExpression()
        {
            return null;
        }
    }
}
