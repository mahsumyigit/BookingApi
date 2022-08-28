using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using BookingApi.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace BookingApi.Context
{
    public class DbContextBase : DbContext
    {
        public DbSet<Apartments>? Apartments { get; set; }

        public DbSet<Bookings>? Bookings { get; set; }

        public DbSet<Opinions>? Opinions { get; set; }

        public DbSet<User>? Users { get; set; }


        public DbContextBase(DbContextOptions<DbContextBase> options) :
        base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.UseSerialColumns();
        }


        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartments>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Image).IsRequired();
                entity.Property(e => e.Adress).IsRequired();
                entity.Property(e => e.Adress2).IsRequired();
                entity.Property(e => e.Booked).IsRequired();
                entity.Property(e => e.Country).IsRequired();
                entity.Property(e => e.Cıty).IsRequired();
                entity.Property(e => e.Direction).IsRequired();
                entity.Property(e => e.Latitude).IsRequired();
                entity.Property(e => e.Longitude).IsRequired();
                entity.HasMany(e => e.Bookings).WithOne(e => e!.Apartments).HasForeignKey(e => e.ApartmenId);


            });
            modelBuilder.Entity<Bookings>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.BookedAt);
                entity.Property(e => e.Confirmed);
                entity.Property(e => e.StartsAt);


            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName);
                entity.Property(e => e.FullName);
                entity.Property(e => e.JobTitle);
                entity.Property(e => e.JobType);
                entity.Property(e => e.Phone);
                entity.Property(e => e.Email);
                entity.Property(e => e.Image);
                entity.Property(e => e.Country);
                entity.Property(e => e.City);
                entity.Property(e => e.OnBoardindCompletion);
                entity.HasMany(e => e.Bookings).WithOne(e => e!.User).HasForeignKey(e => e.UserID);

            });
            modelBuilder.Entity<Opinions>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Opinion).IsRequired();
                entity.Property(e => e.Place);

            });

        }



    }
}