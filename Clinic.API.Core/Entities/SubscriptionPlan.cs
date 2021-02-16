using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class SubscriptionPlan: BaseEntity, IAggregateRoot
    {
        public DateTime Validity { get; set; }
        public string ValidityCondition { get; set; }
        public string PlanName { get; set; }
        public string PlanPrice { get; set; }
        public string Desc { get; set; }
        public string PlanCurrency { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
