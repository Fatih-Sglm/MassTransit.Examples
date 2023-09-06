using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.Shared.Models
{
    public class HelloWorldMessage : BaseMessage
    {
        public string Message { get; set; } = "Hello World";
    }
}
