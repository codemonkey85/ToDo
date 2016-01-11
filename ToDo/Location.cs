using System;
using System.Xml.Serialization;

namespace ToDo
{
    [Serializable]
    public class Location
    {
        public Location()
        {
            Id = Guid.NewGuid();
            Name = Consts.NewLocation;
            Longitude = 0M;
            Latitude = 0M;
            LocationCondition = Consts.LocationConditions.Arriving;
        }

        [XmlElement("Id")]
        private Guid Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Longitude")]
        public decimal Longitude { get; set; }

        [XmlElement("Latitude")]
        public decimal Latitude { get; set; }

        [XmlElement("LocationCondition")]
        public Consts.LocationConditions LocationCondition { get; set; }
    }
}