﻿namespace EventBus.Service.Events;

public class BaseServiceBusEvent
{
    public BaseServiceBusEvent()
    {
        CorrelationId = Guid.NewGuid().ToString();
        CreationDate = DateTime.UtcNow;
    }

    public BaseServiceBusEvent(Guid correlationId, DateTime creationDate)
    {
        CorrelationId = correlationId.ToString();
        CreationDate = creationDate;
    }

    public string CorrelationId { get; set; }
    public DateTime CreationDate { get; private set; }
}