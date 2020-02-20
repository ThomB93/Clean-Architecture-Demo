using System;
using System.Collections.Generic;
using System.Text;

namespace Calendar.Domain.Entities
{
    public class Calendar
    {
        public Guid Id { get; set; }

#nullable enable
        public Teacher? Teacher { get; private set; }
        #nullable disable
        public Hold Hold { get; private set; }

        public Calendar(Teacher teacher, Hold hold)
        {
            this.Teacher = teacher;
            this.Hold = hold;
        }
    }
}
