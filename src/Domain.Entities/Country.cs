using System;

namespace Domain.Entities
{
    public class Country :IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
