using MCS.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace MCS.Api.Services
{
    public class MyFileRepository : IMyFileRepository
    {
        public IList<MyFile> GetMyFilesByPath(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();
            IList<MyFile> result = new List<MyFile>();
            foreach (var dirItem in dirs)
            {
                result.Add(new MyFile() {
                    Name = dirItem.Name,
                    FileType = FileType.Folder
                });
            }
            foreach (var fileItem in files)
            {
                result.Add(new MyFile()
                {
                    Name = fileItem.Name,
                    FileType = FileType.OtherFile
                });
            }
            return result;
        }
    }
}
