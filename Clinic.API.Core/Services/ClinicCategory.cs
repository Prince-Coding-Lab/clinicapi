using Clinic.Api.Core.Dto;
using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Api.Core.Services
{
    public class ClinicCategory : IClinicCategory
    {
       
        public Task<DatabaseResponse> CreateCategoryAsync(CreateCategoryDto category)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> DeleteClinicAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> GetCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseResponse> UpdateCategoryAsync(UpdateCategoryDto category, int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
