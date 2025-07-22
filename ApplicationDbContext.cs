using System.Collections.Generic;
using ScooterInvestApp.Models;

namespace ScooterInvestApp.Data
{
    public class ApplicationDbContext
    {
        public List<Scooter> Scooters { get; set; } = new List<Scooter> {
            new Scooter { Id = 1, Name = "Scooter A", Price = 1000, Available = true },
            new Scooter { Id = 2, Name = "Scooter B", Price = 1200, Available = true }
        };
    }
}