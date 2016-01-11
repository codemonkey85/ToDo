using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ToDo
{
    [Serializable]
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
            Inbox = null;
            Projects = null;
            SmartLists = null;
        }

        [XmlElement("Id")]
        private Guid Id { get; set; }

        [XmlElement("Inbox")]
        public List<Task> Inbox { get; set; }

        [XmlElement("Projects")]
        public List<Project> Projects { get; set; }

        [XmlElement("SmartLists")]
        public List<SmartList> SmartLists { get; set; }
    }
}