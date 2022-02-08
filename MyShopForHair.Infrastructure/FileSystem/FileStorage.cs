using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Infrastructure.FileSystem
{
    public class FileStorage : IFileStorage
    {
        private const string fileFolder = "files";
        private readonly string filePath;

        public FileStorage(string rootFolder)
        {
            filePath = Path.Combine(rootFolder, fileFolder);
        }

        public string Create(Stream stream, string extension)
        {
            var guid = Guid.NewGuid().ToString("N");

            using (var fileStream = new FileStream(Path.Combine(filePath, $"{guid}{extension}"), FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }

            return guid;
        }



        public void Delete(string name, string extension)
        {
            var path = Path.Combine(filePath, name + extension);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
