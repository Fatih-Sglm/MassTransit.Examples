using MassTransit.Consumers.RabbitMq.Config;
using System.Reflection;

namespace MassTransit.Producers.RabbitMq.Config
{
    public static class MassTransitConfig
    {
        // Configure Mass Transit For Project
        public static IServiceCollection ApplyMassTransitRabbitMq(this IServiceCollection services , IConfiguration configuration)
        {
            // Get RabbitMq props from configurations
            RabbitMqConfig config = configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>();

            //MassTransit DI Injection
            services.AddMassTransit(opt=>
            {
                // Add Consumer To DI From Assembly
                opt.AddConsumers(Assembly.GetExecutingAssembly());

                //Add RabbitMq COnfigurations
                opt.UsingRabbitMq((ctx , cfg) =>
                {
                    //Set Host Url
                    cfg.Host($"{config.Host}:{config.Port}" , opt =>
                    {
                        opt.Username(config.UserName);
                        opt.Password(config.PassWord);
                    });

                    // Add consumers to RabbitMq  
                    cfg.AddConsumerToRabbitMq(ctx);
                });
            });
            return services;
        }
    }
}
