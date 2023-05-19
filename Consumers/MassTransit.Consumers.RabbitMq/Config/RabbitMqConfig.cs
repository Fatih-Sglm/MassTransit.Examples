using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassTransit.Producers.RabbitMq.Config
{
    public class RabbitMqConfig
    {
        // RabbitMq Host Url
        public string Host { get; set; }

        //RabbitMq Port
        public int Port { get; set; }

        //RabbitMq UserName
        public string UserName { get; set; }

        //RabbitMq Password
        public string PassWord { get; set; }
    }
}
