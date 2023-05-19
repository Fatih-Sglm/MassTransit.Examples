using MassTransit.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace MassTransit.Consumers.RabbitMq.Consumers
{
    public class ExampleMessageConsumer : IConsumer<ExampleMessage>
    {
        public async Task Consume(ConsumeContext<ExampleMessage> context)
        {
            await Console.Out.WriteLineAsync(JsonSerializer.Serialize(context.Message , new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping }));
        }
    }
}
