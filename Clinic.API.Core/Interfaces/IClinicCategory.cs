using Clinic.Api.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Interfaces
{
    public interface IClinicCategory
    {
        Task<DatabaseResponse> CreateCategoryAsync(CreateCategoryDto category);
        Task<DatabaseResponse> UpdateCategoryAsync(UpdateCategoryDto category, int categoryId);
        Task<DatabaseResponse> GetCategoryByIdAsync(int categoryId);
        Task<DatabaseResponse> GetCategoriesAsync();
        Task<DatabaseResponse> DeleteClinicAsync(int categoryId);
    }
}
