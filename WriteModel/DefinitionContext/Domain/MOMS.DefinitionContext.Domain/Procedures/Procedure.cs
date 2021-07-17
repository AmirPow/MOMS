using Framework.Core.Domain;
using Framework.Domain;

namespace MOMS.DefinitionContext.Domain.Procedures
{
    public class Procedure : EntityBase, IAggregateRoot
    {
        public Procedure(string name , int price)
        {
            Name = name;
            Price = price;
        }
        
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
