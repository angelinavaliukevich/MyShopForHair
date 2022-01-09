using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Models
{
    public class ProductsViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Required]
        [Range(1, 255)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public string Description { get; set; }
        [Required, MaxLength(int.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        [Range(1, 255)]

        [HiddenInput]
        public int BrandId { get; set; }
        [Required]
        [Range(1, 255)]
        public Brand Brand { get; set; }
        public ICollection<Criteria> Criterias { get; set; }
    }
}
