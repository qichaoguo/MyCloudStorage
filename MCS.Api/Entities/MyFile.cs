using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCS.Api.Entities
{
    public class MyFile
    {
        public string Name { get; set; }
        public FileType FileType { get; set; }
    }


    public enum FileType { 
        Folder,//文件夹
        OtherFile//其他文件
    }

}
