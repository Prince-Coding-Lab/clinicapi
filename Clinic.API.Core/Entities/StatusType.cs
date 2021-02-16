using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class LovStatusType : BaseEntity, IAggregateRoot
    {
        [StringLength(10)]
        public string StatusType { get; set; }
        public ICollection<LovStatus> LovStatus { get; set; }
    }
}
