using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyShopForHair.Web.Interfaces
{
    public class BrandViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Required]
        [Range(1, 255)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public ICollection<Products> Products { get; set; }
    }
}