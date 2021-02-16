using Clinic.Api.Core.Dto;
using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Services
{
    public class DoctorService : IDoctorService
    {
        public Task<DatabaseResponse> CreateDoctorAsync(CreateDoctorDto doctor)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> DeleteDoctorAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetDoctorByIdAsync(int doctorId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetDoctorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> UpdateDoctorAsync(UpdateDoctorDto doctor, int doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
