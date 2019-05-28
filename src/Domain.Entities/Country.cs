using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Domain.Entities
{
    public class Country :IEntity
    {
        public int Id { get; set; }
        [Required,Display( Name="Country Name")]
        public String Name { get; set; }
    }
}
