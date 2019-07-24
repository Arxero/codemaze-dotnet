using System;

namespace Entities
{
    public class OwnerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime RequestedAt { get; set; }

        public OwnerDTO(Owner owner)
        {
            Id = owner.Id;
            Name = owner.Name.ToUpper();
            Type = owner.Type;
            CreatedAt = owner.CreatedAt;
            RequestedAt = DateTime.Now;
        }
    }
}
