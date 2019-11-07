using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Dg.Fifth.EntityFrameworkCore;
using Dg.Fifth.Tests.TestDatas;

namespace Dg.Fifth.Tests
{
    public class FifthTestBase : AbpIntegratedTestBase<FifthTestModule>
    {
        public FifthTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<FifthDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<FifthDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<FifthDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<FifthDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<FifthDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<FifthDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<FifthDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<FifthDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
