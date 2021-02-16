using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class Review : BaseEntity, IAggregateRoot
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int ClinicId { get; set; }
        public int Rating { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
