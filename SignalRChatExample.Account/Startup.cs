using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SignalRChatExample.Account
{
    public static class Startup
    {

        public static IServiceCollection AddAccountContext(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddDbContext<>();

            return serviceCollection;
        }
    }
}
