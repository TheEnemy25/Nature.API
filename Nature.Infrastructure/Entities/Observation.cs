﻿using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class Observation : IEntityWithId
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public string Notes { get; set; } = null!;
        //TODO: Add a constraint to allow just one value
        public Guid? PlantId { get; set; } = null;
        public Guid? AnimalId { get; set; } = null;

        public Plant? Plant { get; set; } = null;
        public Animal? Animal { get; set; } = null;
    }
}
