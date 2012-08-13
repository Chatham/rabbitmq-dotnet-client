using System;

namespace RabbitMQ.ServiceModel
{
    class QueueSettingsValidator
    {
        private readonly QueueSettings queueSettings;

        public QueueSettingsValidator(QueueSettings queueSettings)
        {
            this.queueSettings = queueSettings;
        }

        public bool Validate()
        {
            if( queueSettings == null)
                throw new QueueSettingsException("QueueSettings object must be initialized!");

            if(queueSettings.queueName == null || System.String.CompareOrdinal(queueSettings.queueName, "") == 0)
                throw new QueueSettingsException("Queue Name must be specified!");

            if(queueSettings.durable == null || System.String.CompareOrdinal(queueSettings.queueName, "") == 0)
                throw new QueueSettingsException("Durable param must be specified!");

             if(queueSettings.exclusive == null || System.String.CompareOrdinal(queueSettings.exclusive, "") == 0)
                throw new QueueSettingsException("Exclusive param must be specified!");

             if(queueSettings.autoDelete == null || System.String.CompareOrdinal(queueSettings.autoDelete, "") == 0)
                throw new QueueSettingsException("AutoDelete param must be specified!");
            
            return true;
        }
    }

    
}
