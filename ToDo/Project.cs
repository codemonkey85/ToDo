using System;
using System.Collections.Generic;
using System.Drawing;

namespace ToDo
{
    public class Project
    {
        public Project()
        {
            Id = new Guid();
            Name = Consts.NewProject;
            Color = Consts.DefaultColor;
            Tasks = new List<Task>();
            SubProjects = new List<Project>();
        }

        private Guid Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Project> SubProjects { get; set; }
    }
}