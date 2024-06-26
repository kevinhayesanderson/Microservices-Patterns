﻿namespace AspnetRun.Core.Entities.Base
{
    public abstract class EntityBase<TId> : IEntityBase<TId>
    {
        public virtual TId Id { get; protected set; }

        private int? _requestedHashCode;

        public bool IsTransient()
        {
            return Id.Equals(default(TId));
        }

        public override bool Equals(object obj)
        {
            if (obj is not EntityBase<TId> item)
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (GetType() != obj.GetType())
                return false;

            if (item.IsTransient() || IsTransient())
                return false;
            else
                return item == this;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = Id.GetHashCode() ^ 31; // XOR for random distribution (http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx)

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();
        }

        //public static bool operator ==(EntityBase<TId> left, EntityBase<TId> right)
        //{
        //    if (Equals(left, null))
        //        return Equals(right, null) ? true : false;
        //    else
        //        return left.Equals(right);
        //}

        //public static bool operator !=(EntityBase<TId> left, EntityBase<TId> right)
        //{
        //    return !(left == right);
        //}
    }
}