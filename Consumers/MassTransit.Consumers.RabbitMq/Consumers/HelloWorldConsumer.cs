using MassTransit.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace MassTransit.Consumers.RabbitMq.Consumers
{
    public class HelloWorldConsumer : IConsumer<HelloWorldMessage>
    {
        public async Task Consume(ConsumeContext<HelloWorldMessage> context)
        {
            await Console.Out.WriteLineAsync(JsonSerializer.Serialize(context.Message, new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }));
        }
    }
}
