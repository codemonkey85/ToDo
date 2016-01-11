using System;
using System.Xml.Serialization;

namespace ToDo
{
    [Serializable]
    public class Reminder
    {
        public Reminder()
        {
            Id = Guid.NewGuid();
            DateTime = null;
            Location = null;
        }

        [XmlElement("Id")]
        private Guid Id { get; set; }

        [XmlElement("DateTime")]
        public DateTime? DateTime { get; set; }

        [XmlElement("Location")]
        public Location Location { get; set; }
    }
}