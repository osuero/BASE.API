using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class InternalDependencyInjection
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {

            return services;
        }
    }
}
