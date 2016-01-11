using System;

namespace ToDo
{
    public class Location
    {
        public Location()
        {
            Id = new Guid();
            Name = Consts.NewLocation;
            Longitude = 0M;
            Latitude = 0M;
        }

        private Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}