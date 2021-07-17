using System;

namespace MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts
{
    public class DoctorListDto
    {
        public Guid DoctorId { get; set; }
        public string FullName { get; set; }
    }
}
