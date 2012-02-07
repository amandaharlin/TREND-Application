using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrendWinForm;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;

namespace TrendWinForm.Domain.Entities
{
    public abstract class BaseEntity<T> where T : BaseEntity<T>
    {
        public virtual Guid Id { get; private set; }

        private int? oldHashCode;


        public override bool Equals(object obj)
        {
            var other = obj as T;
            if (other == null)
            {
                return false;
            }
            var thisIsNew = Equals(Id, Guid.Empty);
            var otherIsNew = Equals(other.Id, Guid.Empty);
            if (thisIsNew && otherIsNew)
            {
                return ReferenceEquals(this, other);
            }

            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            // once we have a hashcode we'll never change it
            if (oldHashCode.HasValue)
                return oldHashCode.Value; // when this instance is new we use the base hash code
            // and remember it, so an instance can NEVER change its
            // hash code.
            var thisIsNew = Equals(Id, Guid.Empty);
            if (thisIsNew)
            {
                oldHashCode = base.GetHashCode();
                return oldHashCode.Value;
            }
            return Id.GetHashCode();
        }

        public static bool operator ==(BaseEntity<T> lhs, BaseEntity<T> rhs)
        {
            return Equals(lhs, rhs);
        }
        public static bool operator !=(BaseEntity<T> lhs, BaseEntity<T> rhs)
        {
            return !Equals(lhs, rhs);
        }

    }
}
