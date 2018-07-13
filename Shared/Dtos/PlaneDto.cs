using System;

namespace Shared.Dtos
{
    public class PlaneDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TimeSpan LifeTime { get; set; }
    }
}
