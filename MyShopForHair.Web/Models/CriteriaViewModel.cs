using Microsoft.AspNetCore.Mvc;
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
        [DataType(DataType.Date)]
        [HiddenInput]
        public int? GroupId { get; set; }

        [Required]
        [Range(1, 255)]
        public Group Group { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
