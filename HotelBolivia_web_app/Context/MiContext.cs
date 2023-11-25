﻿using HotelBolivia_web_app.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HotelBolivia_web_app.Context
{
    public class MiContext:DbContext
    {
        public MiContext(DbContextOptions options) : base(options)

        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Habitaciones> Habitaciones { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }  
    
}
