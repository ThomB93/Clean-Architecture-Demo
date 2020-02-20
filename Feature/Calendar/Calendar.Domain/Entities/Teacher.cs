using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }

        public Teacher(string firstName, string lastName)
        {
            Name = new Name(firstName, lastName);
        }
    }
}
