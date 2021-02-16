using Clinic.Api.Core.Dto;
using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Services
{
    public class ClinicService : IClinicService
    {
        public Task<DatabaseResponse> CreateClinicAsync(CreateClinicDto clinic)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> DeleteClinicAsync(int clinicId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetClinicByIdAsync(int clinicId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetClinicsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> UpdateClinicAsync(UpdateClinicDto clinic, int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
