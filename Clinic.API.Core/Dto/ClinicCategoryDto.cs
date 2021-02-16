using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Dto
{
    public class ClinicCategoryDto
    {
    }
    public class CreateCategoryDto
    {
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public string CatDescription { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        [StringLength(500)]
        public string CatImage { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
    public class UpdateCategoryDto
    {
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public string CatDescription { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        [StringLength(500)]
        public string CatImage { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
