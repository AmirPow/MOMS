using Framework.Core.Domain;
using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.DefinitionContext.Domain.Procedures
{
    public class Procedure : EntityBase, IAggregateRoot
    {
        public Procedure()
        {

        }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
