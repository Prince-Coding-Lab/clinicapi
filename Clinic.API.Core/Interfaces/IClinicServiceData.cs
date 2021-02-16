using Clinic.Api.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Interfaces
{
    public interface IClinicServiceData
    {
        Task<DatabaseResponse> CreateClinicServiceAsync(CreateClinicServiceDto clinicService);
        Task<DatabaseResponse> UpdateClinicServiceAsync(UpdateClinicServiceDto clinicService, int clinicServiceId);
        Task<DatabaseResponse> GetClinicServiceByIdAsync(int clinicServiceId);
        Task<DatabaseResponse> GetClinicServicesAsync();
        Task<DatabaseResponse> DeleteClinicAsync(int clinicServiceId);
    }
}
