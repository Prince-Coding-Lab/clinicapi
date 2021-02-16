using Clinic.Api.Core.Dto;
using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Services
{
    public class ClinicServiceData : IClinicServiceData
    {
        public Task<DatabaseResponse> CreateClinicServiceAsync(CreateClinicServiceDto clinicService)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> DeleteClinicAsync(int clinicServiceId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetClinicServiceByIdAsync(int clinicServiceId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetClinicServicesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> UpdateClinicServiceAsync(UpdateClinicServiceDto clinicService, int clinicServiceId)
        {
            throw new NotImplementedException();
        }
    }
}
