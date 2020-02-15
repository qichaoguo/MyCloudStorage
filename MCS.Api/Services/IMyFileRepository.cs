using MCS.Api.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCS.Api.Services
{
    public interface IMyFileRepository
    {
        IList<MyFile> GetMyFilesByPath(string path);
    }
}
