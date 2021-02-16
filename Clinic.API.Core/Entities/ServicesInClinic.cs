using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class ServicesInClinic
    {
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

        public int ClinicServiceId { get; set; }
        public ClinicService ClinicService { get; set; }
    }
}
