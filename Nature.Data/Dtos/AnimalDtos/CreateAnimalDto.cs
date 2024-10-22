using Nature.Data.Enums;

namespace Nature.Data.Dtos.AnimalDtos
{
    public class CreateAnimalDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Habitat { get; set; }
        public string ImageFilePath { get; set; }
        public string SoundFilePath { get; set; }
        public string AnimalType { get; set; }
        public MovementType Movement { get; set; }
    }
}
