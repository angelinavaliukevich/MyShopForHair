using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Models
{
    public class CriteriaViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Required]
        [Range(1, 255)]
        public string Name { get; set; }

        public ICollection<Products> Products { get; set; }

        [Display(Name = "Group")]
        [Required, MinLength(1)]
        public int GroupId { get; set; }
        public IEnumerable<SelectListItem> Groups { get; set; }


    }
}
