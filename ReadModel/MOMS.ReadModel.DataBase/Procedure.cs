using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase
{
    public partial class Procedure
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
