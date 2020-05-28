using System;
using System.Collections.Generic;
using System.Text;
using Booking2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booking2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GymClass> GymClasses { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
