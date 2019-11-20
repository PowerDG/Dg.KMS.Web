using Castle.DynamicProxy;
using System.Linq;

namespace KMS.Twelve.Test
{
    public class AOPTest : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            System.Diagnostics.Debug.WriteLine("你正在调用方法 \"{0}\"  参数是 {1}... ",
               invocation.Method.Name,
               string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));
            //在被拦截的方法执行完毕后 继续执行
            invocation.Proceed();

            System.Diagnostics.Debug.WriteLine("方法执行完毕，返回结果：{0}", invocation.ReturnValue);
        }
    }

    public class AopInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
        }
    }
}