using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ToDo
{
    [Serializable]
    public class Task
    {
        public Task()
        {
            Id = Guid.NewGuid();
            Title = Consts.NewTask;
            StartDate = null;
            DuetDate = null;
            Reminders = null;
            Tags = null;
            SubTasks = null;
        }

        [XmlElement("Id")]
        private Guid Id { get; set; }

        [XmlElement("Title")]
        public string Title { get; set; }

        [XmlElement("StartDate")]
        public DateTime? StartDate { get; set; }

        [XmlElement("DuetDate")]
        public DateTime? DuetDate { get; set; }

        [XmlElement("Reminders")]
        public List<Reminder> Reminders { get; set; }

        [XmlElement("Tags")]
        public List<Tag> Tags { get; set; }

        [XmlElement("SubTasks")]
        public List<Task> SubTasks { get; set; }
    }
}