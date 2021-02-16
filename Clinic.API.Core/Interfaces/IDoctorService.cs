using Clinic.Api.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Interfaces
{
    public interface IDoctorService
    {
        Task<DatabaseResponse> CreateDoctorAsync(CreateDoctorDto doctor);
        Task<DatabaseResponse> UpdateDoctorAsync(UpdateDoctorDto doctor, int doctorId);
        Task<DatabaseResponse> GetDoctorByIdAsync(int doctorId);
        Task<DatabaseResponse> GetDoctorsAsync();
        Task<DatabaseResponse> DeleteDoctorAsync(int doctorId);
    }
}
