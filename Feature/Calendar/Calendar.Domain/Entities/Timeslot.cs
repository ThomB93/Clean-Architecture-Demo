using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Timeslot
    {
        public Guid Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public Calendar Calendar { get; set; }

        public ICollection<Booking> Bookings { get; private set; }

        public Timeslot()
        {
            // TODO: Validate startDatetime earlier than EndDatetime
            // general validation logic 
        }

    }
}
