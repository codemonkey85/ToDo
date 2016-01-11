using System;

namespace ToDo
{
    public class Reminder
    {
        public Reminder()
        {
            Id = new Guid();
            DateTime = null;
            Location = new Location();
        }

        private Guid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public Location Location { get; set; }
    }
}