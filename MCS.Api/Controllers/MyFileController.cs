using MCS.Api.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MCS.Api.Controllers
{
    [ApiController]
    [Route("myfile")]
    public class MyFileController:ControllerBase
    {
        private readonly IMyFileRepository _myFileRepository;
        public MyFileController(IMyFileRepository myFileRepository)
        {
            _myFileRepository = myFileRepository ?? 
                throw new ArgumentException(nameof(myFileRepository));
        }

        [HttpGet]
        [HttpGet("{path}")]
        public IActionResult GetFilesByPath(string path = "/")
        {
            path = Environment.CurrentDirectory+"/FileStorage"+ path;
            return new JsonResult(_myFileRepository.GetMyFilesByPath(path));
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddMyFile(string path,IFormCollection form)
        {
            IFormFile formFile = form.Files[0];
            var filePath = Environment.CurrentDirectory + "/FileStorage/" + formFile.FileName;
            if (formFile.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(stream);
                }
            }
            return Ok();
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        [HttpGet("down/{filePath}")]
        public IActionResult DownMyFile(string filePath)
        {
            filePath = Environment.CurrentDirectory + "/FileStorage/" + filePath;
            string fileName = Regex.Match(filePath, "/([^/]*$)").Groups[1].Value;
            return File(new FileStream(filePath, FileMode.Open), "application/octet-stream", fileName);
        }
    }
}
