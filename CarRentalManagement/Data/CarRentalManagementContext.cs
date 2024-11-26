using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Domain;
using CarRentalMangement.Configurations.Entities;
using CarRentalManagement.Configurations.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext (DbContextOptions<CarRentalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagement.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new ColourSeed());
            Builder.ApplyConfiguration(new MakeSeed());
            Builder.ApplyConfiguration(new ModelSeed());

        }
    }
}
