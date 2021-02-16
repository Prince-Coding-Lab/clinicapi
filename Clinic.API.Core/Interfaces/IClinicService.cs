using Clinic.Api.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Interfaces
{
    public interface IClinicService
    {
        Task<DatabaseResponse> CreateClinicAsync(CreateClinicDto clinic);
        Task<DatabaseResponse> UpdateClinicAsync(UpdateClinicDto clinic, int categoryId);
        Task<DatabaseResponse> GetClinicByIdAsync(int clinicId);
        Task<DatabaseResponse> GetClinicsAsync();
        Task<DatabaseResponse> DeleteClinicAsync(int clinicId);
    }
}
