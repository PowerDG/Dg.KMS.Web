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
    public class AutoDIController : ControllerBase// Controller
    {

        public ITestService _testService;

        //public AutoDIController(ITestService testService)
        //{
        //    _testService = testService;
        //}

        // GET: AutoDI
        public List<string> Index()
        {
            var date = _testService.GetList("Name");
            return date;
        }
    }
}