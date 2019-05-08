using System;
using System.Collections.Generic;

namespace CQRSProjectModel.Domain.Models
{
    public abstract class ModelBase
    {
        public Guid Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var entity = obj as ModelBase;

            return entity != null && Id.Equals(entity.Id);
        }

        public static bool operator ==(ModelBase entity1, ModelBase entity2)
        {
            return EqualityComparer<ModelBase>.Default.Equals(entity1, entity2);
        }

        public static bool operator !=(ModelBase entity1, ModelBase entity2)
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
