using System;
using System.Collections.Generic;

namespace CQRSProjectModel.Domain.Core.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var entity = obj as Entity;

            return entity != null && Id.Equals(entity.Id);
        }

        public static bool operator ==(Entity entity1, Entity entity2)
        {
            return EqualityComparer<Entity>.Default.Equals(entity1, entity2);
        }

        public static bool operator !=(Entity entity1, Entity entity2)
        {
            return !(entity1 == entity2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}
