using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Hold
    {
        public Guid Id { get; set; }

        public ICollection<Timeslot> Timeslots { get; private set; }

        public ICollection<Student> Students { get; private set; }

        public Teacher Teacher { get; private set; }

        public Hold()
        {
            
        }

        public bool Validate(Teacher teacher, ICollection<Student> students)
        {
            bool valid = true;



            return valid;
        }
        
    }
}
