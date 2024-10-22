﻿using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public class Animal : IEntityWithId
    {
        public Guid Id { get; set; }

        public Guid? HabitatId { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string Behavior { get; set; }
        public string PhotoUrl { get; set; }
        public string AudioUrl { get; set; }

        public Habitat Habitat { get; set; }
        public ICollection<Threat> Threats { get; set; }
        public ICollection<ConservationEffort> ConservationEfforts { get; set; }
    }
}
