using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CofeeShopWebAPI.Models;

namespace CofeeShopWebAPI.DataLayer
{
    public class ExpressoDbContext : DbContext //(This class from Entity Framework and it's responsible for database CRUD operations)
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}