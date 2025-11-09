using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using EpubReader.Models;

//这个类在于解析epub文件

namespace EpubReader.Services
{
    class EpubServices
    {
        public async Task<EpubBook> LoadBookAsync(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("文件不存在");
            }
            
            //创建ZipArchive对象以读取epub文件:
            using var archive = ZipFile.OpenRead(filePath);

            var book = new EpubBook();

            //1.解析容器文件
            var containerEntry = archive.GetEntry("META-INF/container.xml");
            if (containerEntry == null)
                throw new InvalidDataException("无效的EPUB文件");

            using var containerStream = containerEntry.Open();
            var containerDoc = XDocument.Load(containerStream);
            var rootFile = containerDoc.Descendants().FirstOrDefault(x => x.Name.LocalName == "rootfile")
                ?.Attribute("full-path")?.Value;
        }
    }
}
