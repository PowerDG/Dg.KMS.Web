using Abp.Dapper;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using DapperExtensions;
using DapperExtensions.Mapper;
using Dg.KMS.EntityFrameworkCore.Seed;
using Dg.KMS.People;
using System.Collections.Generic;
using System.Reflection;

namespace Dg.KMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(KMSCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule),
     typeof(AbpDapperModule))]
    public class KMSEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<KMSDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        KMSDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        KMSDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KMSEntityFrameworkModule).GetAssembly());

            //这里会自动去扫描程序集中配置好的映射关系
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(KMSEntityFrameworkModule).GetAssembly() });

        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }

    public class PersonMapper : ClassMapper<Person>
    {
        public PersonMapper()
        {
            Table("Persons");
            Map(x => x.Roles).Ignore();
            AutoMap();
        }
    }
}
