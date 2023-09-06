using MassTransit.Consumers.RabbitMq.Consumers;

namespace MassTransit.Consumers.RabbitMq.Config
{
    public static class ConsumerCongif
    {
        
        //Created an extension method for Consumer register to rabbitmq
        public static void AddConsumerToRabbitMq(this IRabbitMqBusFactoryConfigurator configurator , IRegistrationContext context)
        {
            configurator.ReceiveEndpoint("exampleMessageQueue" , e=> e.ConfigureConsumer<ExampleMessageConsumer>(context));

            configurator.ReceiveEndpoint("HelloWorldConumer", e => e.ConfigureConsumer<HelloWorldConsumer>(context));
        }
    }
}
