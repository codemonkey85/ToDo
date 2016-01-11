using System;
using System.Drawing;
using System.Xml.Serialization;

namespace ToDo
{
    [Serializable]
    public class SmartList
    {
        public SmartList()
        {
            Id = Guid.NewGuid();
            Name = Consts.NewSmartList;
            Color = Consts.DefaultColor;
            Criteria = string.Empty;
        }

        [XmlElement("Id")]
        private Guid Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Color")]
        public Color Color { get; set; }

        [XmlElement("Criteria")]
        public string Criteria { get; set; }
    }
}