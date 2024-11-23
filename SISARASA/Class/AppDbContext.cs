using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static SISARASA.Class.Pengguna;

namespace SISARASA.Class
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Pengguna> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=aws-0-ap-southeast-1.pooler.supabase.com;Database=postgres;Username=postgres.gmeybpfyimugwepqgkwc;Password=MqaaXREOZ6pWKm6t");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pengguna>().ToTable("users");
        }
    }
}
