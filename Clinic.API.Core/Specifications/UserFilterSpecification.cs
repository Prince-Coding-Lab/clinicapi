using Clinic.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Specifications
{
    public class UserFilterSpecification : BaseSpecification<User>
    {
        public UserFilterSpecification(int? roleId, string email)
            : base(i => (!roleId.HasValue || i.RoleId == roleId &&
                ( i.Email == email)))
        {
        }
        public UserFilterSpecification(int?userId)
            : base(b => b.Id == userId)
        {
            AddInclude(b => b.Role);
            AddInclude(b => b.Country);
            AddInclude(b => b.City);
            AddInclude(b => b.Status);
        }
        public UserFilterSpecification(int? roleId, int? userId)
           : base(b => b.RoleId == roleId)
        {
            AddInclude(b => b.Role);
            AddInclude(b => b.Country);
            AddInclude(b => b.City);
            AddInclude(b => b.Status);
        }
        public UserFilterSpecification(string email, string password)
           : base(i => ( i.Email == email &&
               (i.Password == password)))
        {
            AddInclude(b => b.Role);
            AddInclude(b => b.Country);
            AddInclude(b => b.City);
            AddInclude(b => b.Status);
        }
    }
}
