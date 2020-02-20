using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Name
    {
        private string _fullName;

        public Name(string firstName, string lastName)
        {
            this._fullName = firstName + " " + lastName;
        }

        public override string ToString()
        {
            return _fullName;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return obj.ToString() == _fullName;
            }

            return ((Name)obj)._fullName == _fullName;
        }

        public override int GetHashCode()
        {
            return _fullName.GetHashCode();
        }
    }
}
