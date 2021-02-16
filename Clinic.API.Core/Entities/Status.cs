using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class LovStatus : BaseEntity, IAggregateRoot
    {
        [StringLength(30)]
        public string Status { get; set; }
        public int? LovStatusTypeId { get; set; }
        public LovStatusType LovStatusType { get; set; }
        [StringLength(10)]
        public string StatusCode { get; set; }
    }
}
