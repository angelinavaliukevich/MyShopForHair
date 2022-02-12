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
    public class ProductsViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Required, Range(1, 255)]
        public string Name { get; set; }

        [Required, Range(1, 200000)]
        public string Description { get; set; }

        public ushort Price { get; set; }

        [Required, Range(1, 255), HiddenInput]
        public int BrandId { get; set; }

        [Required, Range(1, 255)]

        public int GroupId { get; set; }

        [Required, Range(1, 255)]
        public int CriteriaId { get; set; }

        [Required, Range(1, 255)]


        public ICollection<Criteria> Criterias { get; internal set; }
        public List<SelectListItem> Brands { get; internal set; }
        public List<SelectListItem> GroupsAll { get; internal set; }
        public List<SelectListItem> BrandsAll { get; internal set; }
        public List<SelectListItem> CriterialAll { get; internal set; }


        public Brand Brand { get; internal set; }
        public Criteria Criteria { get; internal set; }
        public Group Group { get; internal set; }
    }
}
