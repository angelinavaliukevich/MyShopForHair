using Microsoft.AspNetCore.Mvc;
using MyShopForHair.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Models
{
    public class RoleModel
    {
        public int? Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

      
    }
}
