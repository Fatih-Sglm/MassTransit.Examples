using MassTransit.Producers.RabbitMq;
using MassTransit.Producers.RabbitMq.Config;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx, services) =>
    {
        services.ApplyMassTransitRabbitMq(ctx.Configuration);
    })
    .Build();

await host.RunAsync();