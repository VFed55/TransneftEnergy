using System;

namespace Energy.Domain.Aggregates
{
    public abstract class Entity
    {
        public long Id { get; protected set; }
    }
}
