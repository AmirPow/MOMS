﻿using Framework.Core.ApplicationService;
using System;
using System.Collections.Generic;

namespace MOMS.CustomerContext.ApplicationServiceContracts.Customers
{
    public class AddReceptionCommand : Command
    {
        public Guid CustomerId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid TherapistId { get; set; }
        public int Price { get; set; }
        public int ExteraPrice { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }
        public List<Guid> ProcedureList { get; set; }
    }
}
