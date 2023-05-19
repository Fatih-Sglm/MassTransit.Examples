using MassTransit.Shared.Models;

namespace MassTransit.Producers.RabbitMq
{
    public class RabbitMqProcuder : BackgroundService
    {

        //private readonly IPublishEndpoint _publishEndpoint;

        private readonly IBus _bus;
        public RabbitMqProcuder(/*IPublishEndpoint publishEndpoint,*/ IBus bus)
        {
            //_publishEndpoint = publishEndpoint;
            _bus = bus;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(500, stoppingToken);
                await Console.Out.WriteLineAsync("Please Enter Message Topic");
                var topic = Console.ReadLine();


                await Console.Out.WriteLineAsync("Please Enter Message");
                var message = Console.ReadLine();

                // Create Message Class
                ExampleMessage exampleMessage = new()
                {
                    Text = message,
                    Topic = topic,
                    WriterBy = "Fatih"
                };

                // Send Message to RabbitMq
                await _bus.Publish(exampleMessage, stoppingToken);
                //await _publishEndpoint.Publish(exampleMessage, stoppingToken);
            }
        }
    }
}