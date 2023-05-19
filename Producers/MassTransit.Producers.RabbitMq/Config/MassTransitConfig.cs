using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.Producers.RabbitMq.Config
{
    public static class MassTransitConfig
    {
        public static IServiceCollection ApplyMassTransitRabbitMq(this IServiceCollection services , IConfiguration configuration)
        {
            // Get RabbitMq props from configurations
            RabbitMqConfig config = configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>();

            //MassTransit DI Injection
            services.AddMassTransit(opt =>
            {

                //Add RabbitMq COnfigurations
                opt.UsingRabbitMq((ctx, cfg) =>
                {
                    //Set Host Url
                    cfg.Host($"{config.Host}:{config.Port}", opt =>
                    {
                        opt.Username(config.UserName);
                        opt.Password(config.PassWord);
                    });

                });
            });
            return services;
        }
    }
}
