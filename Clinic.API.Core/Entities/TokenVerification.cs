using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class TokenVerification : BaseEntity, IAggregateRoot
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Token { get; set; }
        public string Purpose { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
