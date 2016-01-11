using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Task
    {
        public Task()
        {
            Id = new Guid();
            Title = string.Empty;
            StartDate = null;
            DuetDate = null;
            Reminders = new List<Reminder>();
            Tags = new List<Tag>();
            SubTasks = new TaskList();
        }

        private Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DuetDate { get; set; }
        public List<Reminder> Reminders { get; set; }
        public List<Tag> Tags { get; set; }
        public TaskList SubTasks { get; set; }
    }
}