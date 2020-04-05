using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace powerDg.KMS
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<KMSIdentityServerModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
