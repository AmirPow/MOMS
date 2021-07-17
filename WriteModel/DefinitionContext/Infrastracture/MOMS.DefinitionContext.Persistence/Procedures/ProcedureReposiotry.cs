using Framework.Core.Persistence;
using Framework.Persistence;
using MOMS.DefinitionContext.Domain.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MOMS.DefinitionContext.Persistence.Procedures
{
    public class ProcedureReposiotry : RepositoryBase<Procedure>, IProcedureRepository
    {
        public ProcedureReposiotry(IDbContext dbContext) : base(dbContext)
        {

        }
        public void CreateProcedure(Procedure procedure)
        {
            Create(procedure);
        }

        public void DeleteProcedure(Procedure procedure)
        {
            Remove(procedure);
        }

        public Procedure GetByProcedureById(Guid procedureId)
        {
            return _dbContext.Set<Procedure>().SingleOrDefault(e => e.Id == procedureId);
        }

        public void UpdateProcedure(Procedure procedure)
        {
            Update(procedure);
        }

        protected override IEnumerable<Expression<Func<Procedure, object>>> GetAggregateExpression()
        {
            throw new NotImplementedException();
        }
    }
}
