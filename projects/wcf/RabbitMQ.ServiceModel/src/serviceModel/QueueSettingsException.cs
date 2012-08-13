using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabbitMQ.ServiceModel
{
    public class QueueSettingsException : Exception
    {
        public QueueSettingsException(string message):base(message)
        {
            
        }
    }
}
