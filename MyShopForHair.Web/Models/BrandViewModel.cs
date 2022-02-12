using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyShopForHair.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyShopForHair.Web.Models
{
    public class BrandViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

    }
}