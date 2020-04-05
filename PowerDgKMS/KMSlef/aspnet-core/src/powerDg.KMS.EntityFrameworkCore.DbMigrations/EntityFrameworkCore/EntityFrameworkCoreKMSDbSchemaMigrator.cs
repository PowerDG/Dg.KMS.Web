using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using powerDg.KMS.Data;
using Volo.Abp.DependencyInjection;

namespace powerDg.KMS.EntityFrameworkCore
{
    public class EntityFrameworkCoreKMSDbSchemaMigrator
        : IKMSDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreKMSDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the KMSMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<KMSMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}