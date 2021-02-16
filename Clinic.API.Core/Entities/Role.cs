using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class Role :  IAggregateRoot
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
