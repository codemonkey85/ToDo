using System;

namespace ToDo
{
    public class Tag
    {
        public Tag()
        {
            Id = new Guid();
            Name = Consts.NewTag;
        }

        private Guid Id { get; set; }
        public string Name { get; set; }
    }
}