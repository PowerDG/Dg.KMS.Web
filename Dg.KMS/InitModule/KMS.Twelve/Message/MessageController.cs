using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KMS.Twelve.Message
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private Func<int, IMessage> _factory;
        public MessageController(Func<int, IMessage> factory)
        {
            _factory = factory;
        }
        /// <summary>
        /// 依赖注入之Autofac使用总结
        /// https://www.cnblogs.com/struggle999/p/6986903.html
        /// </summary>
        /// <returns></returns>
        public bool Index()
        {
            //var retult = _factory((int)Enums.MPlatform.A平台).Send("去你的吧")
            var retult = _factory(1).Send("去你的吧");
            return retult;
        }
    }
}