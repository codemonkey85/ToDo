﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace ToDo
{
    [Serializable]
    public class Project
    {
        public Project()
        {
            Id = Guid.NewGuid();
            Name = Consts.NewProject;
            Color = Consts.DefaultColor;
            Tasks = null;
            SubProjects = null;
        }

        [XmlElement("Id")]
        private Guid Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Color")]
        public Color Color { get; set; }

        [XmlElement("Tasks")]
        public List<Task> Tasks { get; set; }

        [XmlElement("SubProjects")]
        public List<Project> SubProjects { get; set; }
    }
}