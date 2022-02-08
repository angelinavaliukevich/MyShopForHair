using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public Stream Stream { get; set; }
        public bool IsNew => Stream != null;
    }
}
