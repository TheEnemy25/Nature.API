﻿#nullable disable

using Nature.Infrastructure.Entities.Interfaces;

namespace Nature.Infrastructure.Entities
{
    public sealed class AnimalAudio : IEntityWithId
    {
        public Guid Id { get; set; }

        public byte[] AudioBytes { get; set; }

        public Guid AnimalId { get; set; }

        public Animal Animal { get; set; }
    }
}