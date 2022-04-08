#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitTracker.Models;

namespace FitTracker.Data
{
    public class FitTrackerContext : DbContext
    {
        public FitTrackerContext (DbContextOptions<FitTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<FitTracker.Models.UserModel> UserModel { get; set; }
    }
}
