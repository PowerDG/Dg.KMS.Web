using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Autofac.Extras.DynamicProxy;
using Microsoft.AspNetCore.Mvc;
using TypeDemo.Domain;
using TypeDemo.Log;

namespace TypeDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Intercept(typeof(LogInterceptor))]
    //public class ValuesController : Controller

    public class ValuesController : ControllerBase
    {
        //private readonly IEnumerable<IDog> dogs;

        //public ValuesController(IEnumerable<IDog> _dogs)
        //{
        //    dogs = _dogs;
        //}

        /// <summary>
        /// 3.使用属性注入
        /// </summary>
        public IEnumerable<IDog> dogs { get; set; }

        // GET api/values
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}    
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        [HttpGet]

        public IEnumerable<string> Get()
        {
            List<string> list = new List<string>();
            foreach (var dog in dogs)
            {
                list.Add($"名称：{dog.Name},品种：{dog.Breed}");
            }
            return list.ToArray(); ;
        }
        public  void    More()
        {
            var iocManager = app.ApplicationServices.GetService<IIocManager>();
            List<Parameter> cparams = new List<Parameter>();
            cparams.Add(new NamedParameter("name", "张三"));
            cparams.Add(new NamedParameter("sex", "男"));
            cparams.Add(new TypedParameter(typeof(int), 2));
            var testDemo = iocManager.Resolve<TestDemo>(cparams.ToArray());
            Console.WriteLine($"姓名：{testDemo.Name},年龄：{testDemo.Age},性别：{testDemo.Sex}");


        }
// GET api/values/5
[HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
