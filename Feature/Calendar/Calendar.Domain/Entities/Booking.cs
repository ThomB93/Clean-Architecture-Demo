using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public Timeslot Timeslot { get; private set; }
        public Student Student { get; private set; }

        public Booking()
        {
               //validate booking start and end time
        }

    }
}
