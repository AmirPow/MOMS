using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOMS.CustomerContext.Domain.Customers
{
    public class Payment:EntityBase
    {
        public Payment()
        {

        }
        public Guid ReceptionId { get; set; }
        public DateTime PeymentDateTime { get; set; }
        public int Cash { get; set; }
        public int Pose { get; set; }
    }
}
