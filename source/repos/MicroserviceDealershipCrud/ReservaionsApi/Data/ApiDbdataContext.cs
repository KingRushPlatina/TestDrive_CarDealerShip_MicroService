﻿using Microsoft.EntityFrameworkCore;
using ReservationApi.Models;

namespace ReservationApi.Data
{
    public class ApiDbdataContext:DbContext
    {
       public DbSet<Reservation> Costumers { get; set; }  //returns the Dbset of Costumers
       public DbSet<Vehicle> Vehciles { get; set; }  //returns the Dbset of veicles


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReservationApiDb;");
        }
    }
}
