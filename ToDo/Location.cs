using System;

namespace ToDo
{
    public class Location
    {
        public Location()
        {
            Id = new Guid();
            Longitude = 0M;
            Latitude = 0M;
        }

        private Guid Id { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}