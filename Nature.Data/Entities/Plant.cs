using Nature.Data.Entities.Interfaces;

namespace Nature.Data.Entities
{
    public class Plant : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Habitat { get; set; }
        public string ImageFilePath { get; set; }
    }
}
