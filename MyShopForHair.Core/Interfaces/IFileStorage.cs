using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Interfaces
{
   public interface IFileStorage
    {
        string Create(Stream stream, string extension);
        void Delete(string name, string extension);
    }
}
