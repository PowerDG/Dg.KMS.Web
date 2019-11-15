using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Twelve.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DITestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly ITestService2 _testService2;
        private readonly ITestService3 _testService3;
        public DITestController(ITestService testService, ITestService2 testService2, ITestService3 testService3)
        {
            _testService = testService;
            _testService2 = testService2;
            _testService3 = testService3;
        }
        public List<object> Index([FromServices]ITestService testService11, [FromServices]ITestService2 testService22)
        {
            List<object> dict= new List<object>();
            dict.Add(_testService.GetList("")) ;
            dict.Add( _testService.MyProperty);
            dict.Add( testService11.MyProperty);
            dict.Add( _testService2.MyProperty);
            dict.Add( testService22.MyProperty);
            dict.Add( _testService3.MyProperty);

            return dict;
        }
    }
}