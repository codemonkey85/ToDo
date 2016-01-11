using System;
using System.Collections.Generic;

namespace ToDo
{
    public class TaskList
    {
        public TaskList()
        {
            Id = new Guid();
            Tasks = new List<Task>();
        }

        private Guid Id { get; set; }
        public List<Task> Tasks { get; set; }
    }
}