using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Student
    {
        public ICollection<Booking> BookingCollection { get; private set; }
        public Guid Id { get; private set; }
        public Name Name { get; set; }

        public Student(string firstName, string lastName)
        {
            Name = new Name(firstName, lastName);

        }
    }
}
