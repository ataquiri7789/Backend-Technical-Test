using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.Cross.Proxy.Proxy
{
    public static class Extensions
    {
        public static IServiceCollection AddProxyHttp(this IServiceCollection services)
        {
            services.AddSingleton<IHttpClient, CustomHttpClient>();
            return services;
        }
    }
}
