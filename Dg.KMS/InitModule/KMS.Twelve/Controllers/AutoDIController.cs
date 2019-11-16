using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KMS.Twelve.Test;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMS.Twelve.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoDIController : ControllerBase
    {

        //private readonly ITestService _testService;
        public ITestService _testService { get; set; }

        //public AutoDIController(ITestService testService)
        //{
        //    _testService = testService;
        //}

        // GET: AutoDI 
        /// <summary>
        /// /ASP.NET Core中使用IOC三部曲
        /// https://www.cnblogs.com/GuZhenYin/p/8301500.html
        /// https://www.cnblogs.com/GuZhenYin/p/8297145.html
        /// https://www.cnblogs.com/GuZhenYin/p/8309645.html
        /// </summary>
        /// <returns></returns>
        public List<string> Index()
        {
            var date = _testService.GetList("Name");
            return date;
        }
    }
}