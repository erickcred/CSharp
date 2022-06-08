using System;
using MaoNaMassa1.NotificationContext;

namespace MaoNaMassa1.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }
    }
}