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
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly ITestService2 _testService2;
        private readonly ITestService3 _testService3;
        public TestController(ITestService testService, ITestService2 testService2, ITestService3 testService3)
        {
            _testService = testService;
            _testService2 = testService2;
            _testService3 = testService3;
        }
        //http://localhost:5000/api/DITest

        /// <summary>
        /// https://mp.weixin.qq.com/s?__biz=MzAwNTMxMzg1MA==&mid=2654069818&idx=1&sn=ea95224b69b298276a76d52f5e555750&chksm=80dbc06fb7ac49795f586da6e20312420648e64672c167f777d036230811d14e5fd379804249&scene=21#wechat_redirect
        /// </summary>
        /// <param name="testService11"></param>
        /// <param name="testService22"></param>
        /// <returns></returns>
        public List<object> Index([FromServices]ITestService testService11, [FromServices]ITestService2 testService22)
        {
            List<object> dict = new List<object>();
            dict.Add(_testService.GetList(""));
            dict.Add(_testService.MyProperty);
            dict.Add(testService11.MyProperty);
            dict.Add(_testService2.MyProperty);
            dict.Add(testService22.MyProperty);
            dict.Add(_testService3.MyProperty);


            return dict;
        }
    }
}