using System;
using System.Collections.Generic;

#nullable disable

namespace MOMS.ReadModel.DataBase.Models
{
    public partial class Therapist
    {
        public Therapist()
        {
            Receptions = new HashSet<Reception>();
            Sequencings = new HashSet<Sequencing>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public int MartialStatus { get; set; }
        public DateTime RegDateTime { get; set; }

        public virtual ICollection<Reception> Receptions { get; set; }
        public virtual ICollection<Sequencing> Sequencings { get; set; }
    }
}
