using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DgInitEFCore.Application
{
    public class ShareYunSourseAppService   // : IShareYunSourseAppService
    {
        private readonly IRepository<YunSourse> _yunsourseIRepository;
        public ShareYunSourseAppService(IRepository<YunSourse> yunsourseIRepository)
        {
            _yunsourseIRepository = yunsourseIRepository;
        }
        public async Task GetName()
        {
            var list = _yunsourseIRepository.GetAll().Where(m => !string.IsNullOrEmpty(m.Content)).ToList();

        }
    }
//————————————————
//版权声明：本文为CSDN博主「黄黄同学爱学习」的原创文章，遵循 CC 4.0 BY-SA 版权协议，转载请附上原文出处链接及本声明。
//原文链接：https://blog.csdn.net/huanghuangtongxue/article/details/78937494
}
